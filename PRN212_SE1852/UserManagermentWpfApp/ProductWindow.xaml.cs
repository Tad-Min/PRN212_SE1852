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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductServices productServices = new ProductServices();
        public ProductWindow()
        {
            InitializeComponent();
            productServices.IntializeDataset();
            lvProduct.ItemsSource = productServices.GetAllProducts();
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
