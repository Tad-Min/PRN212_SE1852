using BusinessObjects;
using Services;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NguyenVanThanhDatWPF.Views
{
    /// <summary>
    /// Interaction logic for AdminOrdersView.xaml
    /// </summary>
    public partial class AdminOrdersView : UserControl
    {
        private readonly IAdminActionService _service;
        private readonly int _employeeId;
        public AdminOrdersView(int employeeId)
        {
            InitializeComponent();
            _service = new AdminActionService();
            _employeeId = employeeId;
            LoadOrder();
            
        }

        public async void LoadOrder()
        {
            try
            {
                var data = await _service.GetAllOrders();
                dgOrders.ItemsSource = data;
                
                
            }
            catch (Exception ex)
            { 
                    MessageBox.Show("Error load order: \n" + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void dgOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var order = dgOrders.SelectedItem as Order;
                if (order == null)
                {
                    dgOrderDetails.ItemsSource = null;
                    return;
                }
                var data = await _service.GetAllOrderDetailsByOId(order.OrderId);
                dgOrderDetails.ItemsSource = data;
            }
            catch (Exception ex)
            { 
                    MessageBox.Show("Error load order detail: \n" + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var view = new Views.CUDOrderView(_employeeId);
                Window wd = new CUDWindow(view);
                wd.ShowDialog();
                LoadOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error button add order: \n" + ex.Message, "Error button order!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAddOrderDetail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var order = dgOrders.SelectedItem as Order;
                if (order != null)
                {
                    var view = new Views.CUDOrderDetailView(order.OrderId);
                    Window wd = new CUDWindow(view);
                    wd.ShowDialog();
                    LoadOrder();
                }
                else
                {
                    MessageBox.Show("Please choose a order ", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error button order detail: \n" + ex.Message, "Error button order detail!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEditOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var order = dgOrders.SelectedItem as Order;
                if (order != null) {
                    var view = new Views.CUDOrderView(order.OrderId,_employeeId);
                    Window wd = new CUDWindow(view);
                    wd.ShowDialog();
                    LoadOrder();
                }
                else
                {
                    MessageBox.Show("Please choose a order ", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error button edit order: \n" + ex.Message, "Error button edit order!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEditOrderDetail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var orderDetail = dgOrderDetails.SelectedItem as OrderDetail;
                if (orderDetail != null)
                {
                    var view = new Views.CUDOrderDetailView(orderDetail);
                    Window wd = new CUDWindow(view);
                    wd.ShowDialog();
                    LoadOrder();
                }
                else
                {
                    MessageBox.Show("Please select a order detail", "No selection!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error button edit order detail: \n" + ex.Message, "Error edit order detail!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void btnDeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedOrder = dgOrders.SelectedItem as Order;
                if (selectedOrder == null)
                {
                    MessageBox.Show("Please select a order to delete.", "No selection", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    var isDeleted = await _service.DeleteOrder(selectedOrder.OrderId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Order deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        LoadOrder();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Order.", "Delete Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error seach detail: " + ex.Message, "Error search", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private async void btnDeleteOrderDetail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedOrderDetail = dgOrderDetails.SelectedItem as OrderDetail;
                if (selectedOrderDetail == null)
                {
                    MessageBox.Show("Please select a Order Detail to delete.", "No selection", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to delete this Order Detail?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    var isDeleted = await _service.DeleteOrderDetailByOIdAndPId(selectedOrderDetail.OrderId, selectedOrderDetail.ProductId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Order Detail deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        LoadOrder();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Order Detail.", "Delete Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error seach detail: " + ex.Message, "Error search", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
