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
    /// Interaction logic for CustomerProfile.xaml
    /// </summary>
    public partial class CustomerProfile : UserControl
    {
        private int _customerId;
        private readonly ICustomerActionService _service;
        public CustomerProfile(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            _service = new CustomerActionService();
            LoadData();
        }

        public async void LoadData()
        {
            try
            {
                var user = await _service.GetCustomerById(_customerId);
                if (user == null) 
                {
                    MessageBox.Show("Not found your profile", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
                    var wd = Window.GetWindow(this);
                    new LoginWindow().Show();
                    wd.Close();
                }

                txtCompanyName.Text = user.CompanyName;
                txtContactName.Text = user.ContactName;
                txtAddress.Text = user.Address;
                txtPhone.Text = user.Phone;
                txbCustomerId.Text = user.CustomerId.ToString();
                txtContactTitle.Text = user.ContactTitle;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error LoadData: " + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var customer = await _service.GetCustomerById(_customerId);
                if (customer != null)
                {
                    customer.ContactName = txtCompanyName.Text;
                    customer.Address = txtAddress.Text;
                    customer.Phone = txtPhone.Text;
                    customer.ContactTitle = txtContactTitle.Text;
                    customer.ContactName = txtContactName.Text;

                    var isUpdate = await _service.UpdateCustomer(customer);
                    if (isUpdate)
                    {
                        MessageBox.Show("Update successfully", "Update!", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("Update fail", "Update!", MessageBoxButton.OK, MessageBoxImage.Warning);

                    }

                }
                else
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Update: " + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
