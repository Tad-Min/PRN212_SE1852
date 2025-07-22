using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private readonly LucySalesDataContext _context;
        public ProductDAO()
        {
            _context = new LucySalesDataContext();
        }
        public ProductDAO(LucySalesDataContext context)
        {
            _context = context;
        }
        public async Task<bool> AddProductAsync(Product product)
        {
            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) 
            {
                throw new Exception("Error AddProduct:"+ ex.Message);
            }
        }

        public async Task<List<Product>?> GetAllProducts(string keyword)
        {
            try {
                return await _context.Products
                .Where(p => p.ProductName.Contains(keyword))
                .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error GetAllProducts:" + ex.Message);
            }
        }

        public async Task<Product?> GetProductById(int id)
        {
            try
            {
                return await _context.Products.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error GetAllProducts:" + ex.Message);
            }
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            try
            {
                var exist = await GetProductById(product.ProductId);
                if (exist != null)
                {
                    _context.Products.Update(product);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error UpdateProduct:" + ex.Message);
            }
        }

        public async Task<bool> DeleteProduct(int id)
        {
            try
            {
                var product = await GetProductById(id);
                if (product != null)
                {
                    var orderDetails = await _context.OrderDetails.Where(od => od.ProductId == id).ToListAsync();
                    _context.OrderDetails.RemoveRange(orderDetails);
                    _context.Products.Remove(product);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex) 
            {
                throw new Exception("Error DeleteProduct:" + ex.Message);
            }
        }
    }
}
