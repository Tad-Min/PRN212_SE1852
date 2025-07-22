using BusinessObjects;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    /// Interaction logic for CustomerOrder.xaml
    /// </summary>
    public partial class CustomerOrder : UserControl
    {
        private readonly ICustomerActionService _service;
        private int _customerId;
        public CustomerOrder(int customerId)
        {
            InitializeComponent();
            _service = new CustomerActionService();
            _customerId = customerId;
            LoadData();
        }
        private async void LoadData()
        {
            try
            {

                dgOrders.ItemsSource = await _service.GetAllOrderByCustmerIdAndSearchById(null, _customerId);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error LoadData: " + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private async void dgOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var order = dgOrders.SelectedItem as Order;
                if (order != null)
                {
                    dgOrderDetails.ItemsSource = await _service.GetAllOrderDetailsByOId(order.OrderId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Load orderDetail : " + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text) && int.TryParse(txtSearch.Text, out int value))
                {
                    dgOrders.ItemsSource = await _service.GetAllOrderByCustmerIdAndSearchById(value, _customerId);
                }
                else
                {
                    MessageBox.Show("Search just contain number", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error search: " + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
