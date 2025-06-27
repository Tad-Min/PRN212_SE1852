using Services;
using System.Windows;
using System.Windows.Controls;

namespace NguyenVanThanhDatWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly AuthService _authService;
    private readonly ProductService _productService;
    private readonly CustomerService _customerService;
    private readonly CategoryService _categoryService;
    private readonly OrderService _orderService;

    public MainWindow(AuthService authService)
    {
        InitializeComponent();

        _authService = authService;
        _productService = new ProductService();
        _customerService = new CustomerService();
        _categoryService = new CategoryService();
        _orderService = new OrderService();

        _productService.InitializeDataset();
        _customerService.InitializeDataset();
        _categoryService.InitializeDataset();
        _orderService.InitializeDataset();

        var currentEmployee = _authService.GetCurrentEmployee();
        if (currentEmployee != null)
        {
            this.Title = $"Sales Management System - {currentEmployee.Name} ({currentEmployee.JobTitle})";
        }


        var profilePage = new ProfilePage(_authService);
        tabProfileCustomer.Content = new Frame { Content = profilePage };

        var OrderHistory = new OrderHistoryPage(_authService);
        tabOrderCustomer.Content = new Frame { Content = OrderHistory };

        if (_authService.IsCustomerLoggedIn())
        {
            
            tabOrderCustomer.Visibility = Visibility.Visible;
            tabProfileCustomer.Visibility = Visibility.Visible;
            tabControlMain.SelectedItem = tabOrderCustomer;

            tabManageCustomerAdmin.Visibility = Visibility.Collapsed;
            tabManageProductAdmin.Visibility = Visibility.Collapsed;
            tabOrderAdmin.Visibility = Visibility.Collapsed;
            tabRReportAdmin.Visibility = Visibility.Collapsed;
        }
        if (_authService.IsEmployeeLoggedIn()) {
            tabManageCustomerAdmin.Visibility = Visibility.Visible;
            tabManageProductAdmin.Visibility = Visibility.Visible;
            tabOrderAdmin.Visibility = Visibility.Visible;
            tabRReportAdmin.Visibility = Visibility.Visible;
            tabControlMain.SelectedItem = tabManageCustomerAdmin;

            tabOrderCustomer.Visibility = Visibility.Collapsed;
            tabProfileCustomer.Visibility = Visibility.Collapsed;
        }
    }

    private void Logout_Click(object sender, RoutedEventArgs e)
    {
        _authService.Logout();
        var loginWindow = new LoginWindow();
        loginWindow.Show();
        this.Close();
    }
}