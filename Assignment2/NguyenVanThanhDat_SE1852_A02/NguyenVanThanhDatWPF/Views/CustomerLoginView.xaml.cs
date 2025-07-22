using Services;
using System.Windows;
using System.Windows.Controls;

namespace NguyenVanThanhDatWPF.Views
{
    /// <summary>
    /// Interaction logic for CustomerLoginView.xaml
    /// </summary>
    public partial class CustomerLoginView : UserControl
    {
        private readonly IAuthService _authService;
        public CustomerLoginView()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var phone = txtPhoneNumber.Text;
                var user = await _authService.Login(phone);
                if (user != null)
                {
                    MessageBox.Show("Login successfull!", "Login successfull", MessageBoxButton.OK, MessageBoxImage.Information);
                    new CustomerWindow(user.CustomerId).Show();
                    Window.GetWindow(this).Close();
                }
                else
                {
                    MessageBox.Show("Your UserName or Password error", "Login Fail", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Login admin detail: \n" + ex, "Error Login", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnLoginCustomer_Click(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this);
            if (parentWindow is NguyenVanThanhDatWPF.LoginWindow loginWindow)
            {
                loginWindow.LoginControl.Content = new Views.AdminLoginView();
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
