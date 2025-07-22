using BusinessObjects;
using Services;
using System.Windows;
using System.Windows.Controls;

namespace NguyenVanThanhDatWPF.Views
{
    /// <summary>
    /// Interaction logic for AdminCustomersView.xaml
    /// </summary>
    public partial class AdminCustomersView : UserControl
    {
        private readonly IAdminActionService _service;
        public AdminCustomersView()
        {
            InitializeComponent();
            _service = new AdminActionService();
            LoadData();
        }

        public async void LoadData()
        {
            try
            {
                dgCustomer.ItemsSource = await _service.GetAllCustomers();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error LoadData: " + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void btnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var slcustomer = dgCustomer.SelectedItem as Customer;
                if (slcustomer == null)
                {
                    MessageBox.Show("Please select a customer to delete.", "No selection", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    var isDeleted = await _service.DeleteCustomer(slcustomer.CustomerId);
                    if (isDeleted)
                    {
                        MessageBox.Show("customer deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete customer.", "Delete Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error delete detail: " + ex.Message, "Error delete", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void btnUpdateCustomer_Click(object sender, RoutedEventArgs e)
        {
            var slCustomer = dgCustomer.SelectedItem as Customer;
            if (slCustomer == null)
            {
                MessageBox.Show("Please select a customer to update.", "No selection", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var view = new Views.CUDCustomerView(slCustomer);
            Window wd = new CUDWindow(view);
            wd.ShowDialog();
            LoadData();

        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var view = new Views.CUDCustomerView();
            Window wd = new CUDWindow(view);
            wd.ShowDialog();
            LoadData();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
