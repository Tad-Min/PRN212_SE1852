using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();

        public void IntializeDataset()
        {
            products.Add(new Product { Id = 1, Name = "Coca", Price = 200, Quantity = 10 });
            products.Add(new Product { Id = 2, Name = "Coa", Price = 200, Quantity = 10 });
            products.Add(new Product { Id = 3, Name = "ca", Price = 200, Quantity = 10 });
            products.Add(new Product { Id = 4, Name = "a", Price = 200, Quantity = 10 });
            products.Add(new Product { Id = 5, Name = "la", Price = 200, Quantity = 10 });
            products.Add(new Product { Id = 6, Name = "Co", Price = 200, Quantity = 10 });
            products.Add(new Product { Id = 7, Name = "oa", Price = 200, Quantity = 10 });
            products.Add(new Product { Id = 8, Name = "al", Price = 200, Quantity = 10 });
            products.Add(new Product { Id = 9, Name = "Cocqa", Price = 200, Quantity = 10 });
            products.Add(new Product { Id = 10, Name = "Coc12a", Price = 200, Quantity = 10 });
            products.Add(new Product { Id = 11, Name = "Coca4", Price = 200, Quantity = 10 });

        }

        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
