using Services;
using System.Windows;
using System.Windows.Controls;

namespace NguyenVanThanhDatWPF.Views
{
    /// <summary>
    /// Interaction logic for AdminLoginView.xaml
    /// </summary>
    public partial class AdminLoginView : UserControl
    {
        private readonly IAuthService _authService;
        public AdminLoginView()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userName = txtUserName.Text;
                var pwd = txtPassword.Password;
                var user = await _authService.Login(userName, pwd);
                if (user != null)
                {
                    MessageBox.Show("Login successfull!", "Login successfull", MessageBoxButton.OK, MessageBoxImage.Information);
                    var parentWindow = Window.GetWindow(this);
                    Window wd = new AdminWindow(user);
                    wd.Show();
                    parentWindow.Close();
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
                loginWindow.LoginControl.Content = new Views.CustomerLoginView();
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
