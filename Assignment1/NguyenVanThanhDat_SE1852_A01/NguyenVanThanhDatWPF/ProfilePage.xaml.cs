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

namespace NguyenVanThanhDatWPF
{
    /// <summary>
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        private readonly AuthService _authService;
        private readonly OrderService _orderService;
        private readonly CustomerService _customerService;

        public ProfilePage()
        {
            InitializeComponent();
            _authService = new AuthService();
            _orderService = new OrderService();
            _customerService = new CustomerService();

            _orderService.InitializeDataset();
            _customerService.InitializeDataset();
        }
        public ProfilePage(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
            _orderService = new OrderService();
            _customerService = new CustomerService();

            _orderService.InitializeDataset();
            _customerService.InitializeDataset();

            var currentCustomer = _authService.GetCurrentCustomer();
            if (currentCustomer != null)
            {
                this.Title = $"Customer Portal - {currentCustomer.CompanyName} ({currentCustomer.ContactName})";
            }
            if (currentCustomer != null)
            {
                txtCompanyName.Text = currentCustomer.CompanyName;
                txtContactName.Text = currentCustomer.ContactName;
                txtContactTitle.Text = currentCustomer.ContactTitle;
                txtAddress.Text = currentCustomer.Address;
                txtPhone.Text = currentCustomer.Phone;
            }
        }



        private void BtnSaveProfile_Click(object sender, RoutedEventArgs e)
        {
            var currentCustomer = _authService.GetCurrentCustomer();
            if (currentCustomer == null)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text) || string.IsNullOrWhiteSpace(txtContactName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            currentCustomer.CompanyName = txtCompanyName.Text.Trim();
            currentCustomer.ContactName = txtContactName.Text.Trim();
            currentCustomer.ContactTitle = txtContactTitle.Text.Trim();
            currentCustomer.Address = txtAddress.Text.Trim();
            currentCustomer.Phone = txtPhone.Text.Trim();
            if (_customerService.UpdateCustomer(currentCustomer))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Title = $"Customer Portal - {currentCustomer.CompanyName} ({currentCustomer.ContactName})";
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
