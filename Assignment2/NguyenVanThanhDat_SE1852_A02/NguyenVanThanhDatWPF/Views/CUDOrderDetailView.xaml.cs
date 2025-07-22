using BusinessObjects;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NguyenVanThanhDatWPF.Views
{
    /// <summary>
    /// Interaction logic for CUDOrderDetailView.xaml
    /// </summary>
    public partial class CUDOrderDetailView : UserControl
    {
        private readonly IAdminActionService _service;
        private readonly OrderDetail? _orderDetail;
        private readonly int _orderId;
        public CUDOrderDetailView(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            _service = new AdminActionService();
            LoadData();
        }
        public CUDOrderDetailView(OrderDetail orderDetail)
        {
            InitializeComponent();
            _service = new AdminActionService();
            _orderDetail = orderDetail;
            LoadData();
        }

        public async void LoadData()
        {
            try
            {
                if (_orderDetail != null && _orderDetail.ProductId != null)
                {
                    // Chế độ Update
                    btnUpdate.Visibility = Visibility.Visible;
                    btnAdd.Visibility = Visibility.Collapsed;

                    cbProducts.ItemsSource = await _service.GetAllProducts("");
                    cbProducts.DisplayMemberPath = "ProductName";
                    cbProducts.SelectedValuePath = "ProductId";
                    cbProducts.SelectedValue = _orderDetail.ProductId;

                    txbOrderId.Text = _orderDetail.OrderId.ToString();
                    txtDiscount.Text = _orderDetail.Discount.ToString();
                    txtQuantity.Text = _orderDetail.Quantity.ToString();
                    txtUnitPrice.Text = _orderDetail.UnitPrice.ToString();
                }
                else
                {
                    // Chế độ Add
                    btnUpdate.Visibility = Visibility.Collapsed;
                    btnAdd.Visibility = Visibility.Visible;

                    cbProducts.ItemsSource = await _service.GetAllProducts("");
                    cbProducts.DisplayMemberPath = "ProductName";
                    cbProducts.SelectedValuePath = "ProductId";

                    txbOrderId.Text = _orderId.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error LoadData: " + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate OrderId
                if (!int.TryParse(txbOrderId.Text, out int orderId))
                {
                    MessageBox.Show("Order Id must be a number.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Validate Product
                if (cbProducts.SelectedValue == null)
                {
                    MessageBox.Show("Please select a product.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                int productId = (int)cbProducts.SelectedValue;

                // Validate UnitPrice
                if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
                {
                    MessageBox.Show("Unit Price must be a decimal number.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Validate Quantity
                if (!short.TryParse(txtQuantity.Text, out short quantity))
                {
                    MessageBox.Show("Quantity must be a number.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Validate Discount
                if (!float.TryParse(txtDiscount.Text, out float discount))
                {
                    MessageBox.Show("Discount must be a number.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Kiểm tra Discount hợp lệ (giả sử constraint là 0 <= Discount <= 1)
                if (discount < 0 || discount > 1)
                {
                    MessageBox.Show("Discount must be between 0 and 1 (e.g., 0.2 for 20% off).", "Invalid Discount", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                var orderDetail = new OrderDetail
                {
                    OrderId = orderId,
                    ProductId = productId,
                    UnitPrice = unitPrice,
                    Quantity = quantity,
                    Discount = discount
                };

                var isAdded = await _service.AddOrderDetail(orderDetail);
                if (isAdded)
                {
                    MessageBox.Show("Order detail added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add order detail. It may already exist.", "Add Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order detail: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Window wd = Window.GetWindow(this);
                wd.Close();
            }
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate OrderId
                if (!int.TryParse(txbOrderId.Text, out int orderId))
                {
                    MessageBox.Show("Order Id must be a number.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Validate Product
                if (cbProducts.SelectedValue == null)
                {
                    MessageBox.Show("Please select a product.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                int productId = (int)cbProducts.SelectedValue;

                // Validate UnitPrice
                if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
                {
                    MessageBox.Show("Unit Price must be a decimal number.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Validate Quantity
                if (!short.TryParse(txtQuantity.Text, out short quantity))
                {
                    MessageBox.Show("Quantity must be a number.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Validate Discount
                if (!float.TryParse(txtDiscount.Text, out float discount))
                {
                    MessageBox.Show("Discount must be a number.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                var orderDetail = await _service.GetOrderDetailsByOIdAndPIdAsync(_orderDetail.OrderId, _orderDetail.ProductId);
                if(orderDetail == null)
                {
                    MessageBox.Show("Not found orderDetail", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                orderDetail.ProductId = productId;
                orderDetail.UnitPrice = unitPrice;
                orderDetail.Quantity = quantity;
                orderDetail.Discount = discount;
               

                var isUpdated = await _service.UpdateOrderDetail(orderDetail);
                if (isUpdated)
                {
                    MessageBox.Show("Order detail updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update order detail. It may not exist.", "Update Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order detail: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Window wd = Window.GetWindow(this);
                wd.Close();
            }
        }
    }
}
