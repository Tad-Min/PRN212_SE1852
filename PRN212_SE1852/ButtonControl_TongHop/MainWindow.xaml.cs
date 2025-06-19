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

namespace ButtonControl_TongHop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnTong_Click(object sender, RoutedEventArgs e)
        {
            int a = int.TryParse(txtA.Text, out a) ? a : 0;
            int b = int.TryParse(txtB.Text, out b) ? b : 0;
            int tong = a + b;
            tbKetQua.Text = tong + "";
        }
        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}