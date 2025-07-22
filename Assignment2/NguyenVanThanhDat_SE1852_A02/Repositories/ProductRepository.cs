using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO _productDAO = new ProductDAO();
        public ProductRepository() {
            _productDAO = new ProductDAO();
        }
        public ProductRepository(ProductDAO productDAO)
        {
            _productDAO = productDAO;
        }

        public async Task<bool> AddProductAsync(Product product)
        {
            return await _productDAO.AddProductAsync(product);
        }

        public async Task<bool> DeleteProduct(int id)
        {
            return await _productDAO.DeleteProduct(id);
        }

        public async Task<List<Product>?> GetAllProducts(string keyword)
        {
            return await _productDAO.GetAllProducts(keyword);
        }

        public async Task<Product?> GetProductById(int id)
        {
            return await _productDAO.GetProductById(id);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            return await _productDAO.UpdateProduct(product);
        }
    }
}
