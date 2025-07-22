using BusinessObjects;
using System.Windows;

namespace NguyenVanThanhDatWPF
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private Employee _employee;
        public AdminWindow(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
        }

        private void btnReport_Checked(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Views.AdminReportView();
        }

        private void btnCustomers_Checked(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Views.AdminCustomersView();
        }

        private void btnProducts_Checked(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Views.AdminProductsview();
        }

        private void btnOrders_Checked(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Views.AdminOrdersView(_employee.EmployeeId);
        }

        private void btnProfile_Checked(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new Views.AdminProfileView(_employee.EmployeeId);
        }

        private void btnLogout_Click_1(object sender, RoutedEventArgs e)
        {
            Window wd = new LoginWindow();
            wd.Show();
            Close();
        }
    }
}
