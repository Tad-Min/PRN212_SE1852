using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IProductServices
    {
        List<Product> GetAllProducts();
        public void IntializeDataset();
    }
}
