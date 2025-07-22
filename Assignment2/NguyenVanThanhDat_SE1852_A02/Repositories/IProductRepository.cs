using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        Task<bool> AddProductAsync(Product product);
        Task<List<Product>?> GetAllProducts(string keyword);
        Task<Product?> GetProductById(int id);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int id);
    }
}
