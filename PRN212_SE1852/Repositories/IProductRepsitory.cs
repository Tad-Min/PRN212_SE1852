using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepsitory
    {
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        List<Product> GetAllProducts();
        public void IntializeDataset();
    }
}
