using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productDAO = new ProductDAO();

        public List<Product> GetAllProducts()
        {
            return productDAO.GetAllProducts();
        }

        public void InitializeDataset()
        {
            productDAO.InitializeDataset();
        }

        public Product? GetProductById(int id)
        {
            return productDAO.GetProductById(id);
        }

        public bool SaveProduct(Product product)
        {
            return productDAO.SaveProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return productDAO.UpdateProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return productDAO.DeleteProduct(id);
        }

        public List<Product> SearchProducts(string keyword)
        {
            return productDAO.SearchProducts(keyword);
        }
    }
}
