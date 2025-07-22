using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccessLayer
{
    public class OrderDAO
    {
        private readonly LucySalesDataContext _context;
        public OrderDAO()
        {
            _context = new LucySalesDataContext();
        }

        public OrderDAO(LucySalesDataContext context)
        {
            _context = context;
        }

        public async Task<bool> AddOrder(Order order)
        {
            try
            {
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) 
            {
                throw new Exception("Error AddOrder" + ex.Message);
            }
            
        }

        public async Task<List<Order>?> GetAllOrders()
        {
            try
            {
                return await _context.Orders
                    .OrderByDescending(x => x.OrderDate)
                    .ToListAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Error GetAllOrders" + ex.Message);
            }
        }

        public async Task<Order?> GetOrderById(int id)
        {
            try
            {
                return await _context.Orders.Include(o => o.OrderDetails).FirstOrDefaultAsync(o => o.OrderId == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error GetOrderById" + ex.Message);
            }
            
        }

        public async Task<bool> UpdateOrder(Order order)
        {
            try
            {
                _context.Orders.Update(order);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error GetOrderById" + ex.Message);
            }
            
        }

        public async Task<bool> DeleteOrder(int id)
        {
            try
            {
                var order = await GetOrderById(id);
                if (order != null)
                {
                    _context.Orders.Remove(order);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error DeleteOrder: " + ex.Message);
            }
        }

        public async Task<List<Order>?> GetAllOrdersInDate(DateTime startDate, DateTime endDate)
        {
            try
            {
                return await _context.Orders.Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                    .OrderByDescending(o => o.OrderDate)
                    .ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error GetAllOrdersInDate: " + ex.Message);
            }
        }

        public async Task<List<Order>?> GetAllOrderByCustmerIdAndSearchById(int? key, int userId)
        {
            try
            {
                
                if (key != null)
                {
                    return await _context.Orders.Where(x => x.OrderId.ToString().Contains(key.ToString() ?? "") && x.CustomerId == userId).ToListAsync();
                }
                return await _context.Orders.Where(x => x.CustomerId == userId).ToListAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Error GetAllOrderByCustmerIdAndSearchById: " + ex.Message);
            }
        }

    }
}
