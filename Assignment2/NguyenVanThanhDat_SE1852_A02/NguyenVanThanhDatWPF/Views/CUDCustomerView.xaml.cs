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
    /// Interaction logic for CUDCustomerView.xaml
    /// </summary>
    public partial class CUDCustomerView : UserControl
    {
        private Customer? _customer;
        private readonly IAdminActionService _service;
        public CUDCustomerView()
        {
            InitializeComponent();
            _service = new AdminActionService();

        }

        public CUDCustomerView(Customer customer)
        {
            InitializeComponent();
            _service = new AdminActionService();
            _customer = customer;
        }

        public async void LoadData()
        {
            try
            {
                if (_customer != null) 
                {
                    btnUpdate.Visibility = Visibility.Visible;
                    btnAdd.Visibility = Visibility.Collapsed;

                    txbCustomerId.Text = _customer.CustomerId.ToString();
                    txtCompanyName.Text = _customer.CompanyName;
                    txtContactName.Text = _customer.ContactName;
                    txtContactTitle.Text = _customer.ContactTitle;
                    txtAddress.Text = _customer.Address;
                    txtPhone.Text = _customer.Phone;
                }
                else
                {
                    btnUpdate.Visibility = Visibility.Collapsed;
                    btnAdd.Visibility = Visibility.Visible;

                    dpCustomerId.Visibility = Visibility.Collapsed;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error LoadData Detail \n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
