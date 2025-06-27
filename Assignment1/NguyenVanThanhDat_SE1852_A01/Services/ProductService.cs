using BusinessObjects;
using Repositories;

namespace Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public void InitializeDataset()
        {
            _productRepository.InitializeDataset();
        }

        public Product? GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public bool SaveProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName) || product.UnitPrice <= 0)
            {
                return false;
            }

            return _productRepository.SaveProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName) || product.UnitPrice <= 0)
            {
                return false;
            }

            return _productRepository.UpdateProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public List<Product> SearchProducts(string keyword)
        {
            return _productRepository.SearchProducts(keyword);
        }
    }
}
