using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
   
    public class ProductRepsitory : IProductRepsitory
    {
        ProductDAO productDAO = new ProductDAO();
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            
            productDAO.IntializeDataset();
            return productDAO.GetAllProducts();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void IntializeDataset()
        {
            productDAO.IntializeDataset();
        }
    }
}
