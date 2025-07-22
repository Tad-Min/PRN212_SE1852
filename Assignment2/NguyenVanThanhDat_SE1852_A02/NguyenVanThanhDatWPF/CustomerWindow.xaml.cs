using System.Windows;

namespace NguyenVanThanhDatWPF
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private readonly int _customerId;
        public CustomerWindow(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        private void btnOrders_Checked(object sender, RoutedEventArgs e)
        {
            var view = new Views.CustomerOrder(_customerId);
            MainContent.Content = view;
        }

        private void btnProfile_Checked(object sender, RoutedEventArgs e)
        {
            var view = new Views.CustomerProfile(_customerId);
            MainContent.Content = view;
        }

        private void btnLogout_Click_1(object sender, RoutedEventArgs e)
        {
            Window wd = new LoginWindow();
            wd.Show();
            Close();
        }
    }
}
