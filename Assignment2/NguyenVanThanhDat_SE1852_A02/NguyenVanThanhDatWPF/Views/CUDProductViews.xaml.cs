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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NguyenVanThanhDatWPF.Views
{
    /// <summary>
    /// Interaction logic for CUDProductViews.xaml
    /// </summary>
    public partial class CUDProductViews : UserControl
    {
        private readonly IAdminActionService _service;
        private readonly Product? _product;
        public CUDProductViews(Product product)
        {
            InitializeComponent();
            _product = product;
            _service = new AdminActionService();
            LoadProduct();
        }
        public CUDProductViews()
        {
            InitializeComponent();
            _product = null;
            _service = new AdminActionService();
            LoadProduct();
        }

        public async void LoadProduct()
        {
            try
            {
                if (_product != null)
                {
                    dpViewProductId.Visibility = Visibility.Visible;
                    btnUpdate.Visibility = Visibility.Visible;
                    btnAdd.Visibility = Visibility.Collapsed;

                    tbxProductId.Text = _product.ProductId.ToString();
                    txtProductName.Text = _product.ProductName;
                    txtSupplierId.Text = _product.SupplierId.ToString();
                    txtQuantityPerUnit.Text = _product.QuantityPerUnit ?? "";
                    cbCategory.ItemsSource = await _service.GetAllCategories();
                    cbCategory.DisplayMemberPath = "CategoryName"; // Hiển thị tên
                    cbCategory.SelectedValuePath = "CategoryId";   // Giá trị chọn là Id
                    cbCategory.SelectedValue = _product.CategoryId;
                    txtUnitsInStock.Text = _product.UnitsInStock.ToString();
                    txtUnitPrice.Text = _product.UnitPrice.ToString();
                    txtQuantityPerUnit.Text = _product.QuantityPerUnit;
                    txtReorderLevel.Text = _product.ReorderLevel.ToString();
                    chkDiscontinued.IsChecked = _product.Discontinued;
                }
                else
                {
                    dpViewProductId.Visibility = Visibility.Collapsed;
                    btnUpdate.Visibility = Visibility.Collapsed;
                    btnAdd.Visibility = Visibility.Visible;

                    cbCategory.ItemsSource = await _service.GetAllCategories();
                    cbCategory.DisplayMemberPath = "CategoryName"; // Hiển thị tên
                    cbCategory.SelectedValuePath = "CategoryId";   // Giá trị chọn là Id
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load product detail: " + ex.Message, "Error load product!", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                var productName = txtProductName.Text?.Trim();
                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Product Name cannot be null or empty", "Error Product Name!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!int.TryParse(txtSupplierId.Text, out var supplierId))
                {
                    MessageBox.Show("Supplier Id must be an integer number", "Error Supplier Id!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (cbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category", "Error Category!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                int categoryId = (int)cbCategory.SelectedValue;

                var quantityPerUnit = txtQuantityPerUnit.Text?.Trim();
                
                if (!decimal.TryParse(txtUnitPrice.Text, out var unitPrice))
                {
                    MessageBox.Show("Unit price must be an real number", "Error unit price!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!short.TryParse(txtUnitsInStock.Text, out var unitsInStock))
                {
                    MessageBox.Show("Units In Stock must be a number", "Error Units In Stock!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!short.TryParse(txtReorderLevel.Text, out var reorderLevel))
                {
                    MessageBox.Show("Reorder Level must be a number", "Error Reorder Level!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                bool discontinued = chkDiscontinued.IsChecked == true;

                Product product = new Product
                {
                    ProductName = productName,
                    SupplierId = supplierId,
                    CategoryId = categoryId,
                    QuantityPerUnit = quantityPerUnit,
                    UnitPrice = unitPrice,
                    UnitsInStock = unitsInStock,
                    ReorderLevel = reorderLevel,
                    Discontinued = discontinued
                };

                var isAdded = await _service.AddProduct(product);
                if (isAdded)
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add product. Product may already exist.", "Add Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add product detail: " + ex.Message, "Error add product!", MessageBoxButton.OK, MessageBoxImage.Error);
                Window wd = Window.GetWindow(this);
                wd.Close();
            }
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var productName = txtProductName.Text?.Trim();
                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Product Name cannot be null or empty", "Error Product Name!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                
                if (!int.TryParse(txtSupplierId.Text, out var supplierId))
                {
                    MessageBox.Show("Supplier Id must be an integer number", "Error Supplier Id!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                
                if (cbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category", "Error Category!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                int categoryId = (int)cbCategory.SelectedValue;

                var quantityPerUnit = txtQuantityPerUnit.Text?.Trim();

                if (!short.TryParse(txtUnitsInStock.Text, out var unitsInStock))
                {
                    MessageBox.Show("Units In Stock must be a number", "Error Units In Stock!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (!short.TryParse(txtReorderLevel.Text, out var reorderLevel))
                {
                    MessageBox.Show("Reorder Level must be a number", "Error Reorder Level!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                bool discontinued = chkDiscontinued.IsChecked == true;

                _product.ProductName = productName;
                _product.SupplierId = supplierId;
                _product.CategoryId = categoryId;
                _product.QuantityPerUnit = quantityPerUnit;
                _product.UnitsInStock = unitsInStock;
                _product.ReorderLevel = reorderLevel;
                _product.Discontinued = discontinued;

                var isUpdated = await _service.UpdateProduct(_product);
                if (isUpdated)
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update product. Product may not exist.", "Update Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    Window wd = Window.GetWindow(this);
                    wd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error update product detail: " + ex.Message, "Error update product!", MessageBoxButton.OK, MessageBoxImage.Error);
                Window wd = Window.GetWindow(this);
                wd.Close();
            }
        }
    }
}
