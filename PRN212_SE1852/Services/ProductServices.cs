using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductServices : IProductServices
    {
        public readonly IProductRepsitory _productRepsitory;
        public ProductServices() { 
            _productRepsitory = new ProductRepsitory();
        }
        public List<Product> GetAllProducts()
        {
            return _productRepsitory.GetAllProducts();
        }

        public void IntializeDataset()
        {
            _productRepsitory.IntializeDataset();
        }
    }
}
