using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessObjects;
using Services;

namespace UserManagermentWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserServices userServices = new UserServices();
        public MainWindow()
        {
            InitializeComponent();
            HienThiToanBoUser();
        }

        private void HienThiToanBoUser()
        {
            List<User> users = userServices.GetAllUsers();
            lbUser.ItemsSource = users;
        }

        private void lbUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}