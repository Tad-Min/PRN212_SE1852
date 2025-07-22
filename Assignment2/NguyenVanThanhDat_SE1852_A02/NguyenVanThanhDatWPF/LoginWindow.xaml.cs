using System.Windows;

namespace NguyenVanThanhDatWPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginControl.Content = new Views.AdminLoginView();
        }

        private void btnCustomerLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginControl.Content = new Views.CustomerLoginView();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
