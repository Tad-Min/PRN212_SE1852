using BusinessObjects;
using Services;
using System.Windows;
using System.Windows.Controls;

namespace NguyenVanThanhDatWPF.Views
{
    /// <summary>
    /// Interaction logic for AdminProductsview.xaml
    /// </summary>
    public partial class AdminProductsview : UserControl
    {
        private readonly IAdminActionService _service;
        public AdminProductsview()
        {
            InitializeComponent();
            _service = new AdminActionService();
            LoadProducts();
        }

        public async void LoadProducts()
        {
            try
            {
                var data = await _service.GetAllProducts("");
                dgProducts.ItemsSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load product detail: " + ex.Message, "Error load product!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAddProduct_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var addProductView = new Views.CUDProductViews(); 
            Window wd = new CUDWindow(addProductView);
            wd.ShowDialog();
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = dgProducts.SelectedItem as Product;
            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product to update.", "No selection", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var updateProductView = new Views.CUDProductViews(selectedProduct);
            Window wd = new CUDWindow(updateProductView);
            wd.ShowDialog();
            LoadProducts();
        }

        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = await _service.GetAllProducts(txtSearch.Text);
                dgProducts.ItemsSource = data;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error seach detail: " + ex.Message, "Error search", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 
                var selectedProduct = dgProducts.SelectedItem as Product;
                if (selectedProduct == null)
                {
                    MessageBox.Show("Please select a product to delete.", "No selection", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    var isDeleted = await _service.DeleteProductById(selectedProduct.ProductId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product.", "Delete Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error seach detail: " + ex.Message, "Error search", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
