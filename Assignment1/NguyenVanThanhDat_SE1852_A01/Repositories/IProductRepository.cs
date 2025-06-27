using BusinessObjects;

namespace Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
        public void InitializeDataset();
        public Product? GetProductById(int id);
        public bool SaveProduct(Product product);
        public bool UpdateProduct(Product product);
        public bool DeleteProduct(int id);
        public List<Product> SearchProducts(string keyword);

    }
}
