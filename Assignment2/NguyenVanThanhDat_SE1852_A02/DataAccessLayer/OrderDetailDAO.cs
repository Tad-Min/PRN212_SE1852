using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderDetailDAO
    {
        private readonly LucySalesDataContext _context;
        public OrderDetailDAO()
        {
            _context = new LucySalesDataContext();
        }

        public OrderDetailDAO(LucySalesDataContext context)
        {
            _context = context;
        }
        public async Task<List<OrderDetail>?> GetAllOrderDetailsByOId(int id)
        {
            try
            {
                return await _context.OrderDetails.Where(x => x.OrderId == id).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error GetOrderDetailsByOId: " + ex.Message);
            }
        }

        public async Task<OrderDetail?> GetOrderDetailsByOIdAndPIdAsync(int orderId, int productId)
        {
            try
            {
                return await _context.OrderDetails.FirstOrDefaultAsync(x => x.OrderId == orderId && x.ProductId == productId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error GetOrderDetailsByOId: " + ex.Message);
            }
        }
        public async Task<bool> AddOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                var existOrder = await _context.Orders.FindAsync(orderDetail.OrderId);
                var existProduct = await _context.Products.FindAsync(orderDetail.ProductId);
                if (existOrder != null && existProduct != null)
                {
                    var existOrderDetail = await _context.OrderDetails.FirstOrDefaultAsync(x => x.OrderId == orderDetail.OrderId &&
                                                                                                x.ProductId == orderDetail.ProductId);
                    if (existOrderDetail != null) {
                        existOrderDetail.Quantity += orderDetail.Quantity;
                        await _context.SaveChangesAsync();
                        return true;
                    }
                    _context.OrderDetails.Add(orderDetail);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error AddOrderDetail: "+ ex.Message);
            }
        }

        public async Task<bool> UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                var existOrderDetail = await _context.OrderDetails.FirstOrDefaultAsync(x => x.OrderId == orderDetail.OrderId &&
                                                                                            x.ProductId == orderDetail.ProductId);
                if (existOrderDetail != null) 
                {
                    _context.OrderDetails.Update(existOrderDetail);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error UpdateOrderDetail: " + ex.Message);
            }
        }

        public async Task<bool> DeleteOrderDetailByOIdAndPId(int orderId, int productId)
        {
            try
            {
                var existOrderDetail = await _context.OrderDetails.FirstOrDefaultAsync(x => x.OrderId == orderId &&
                                                                                            x.ProductId == productId);
                if (existOrderDetail != null) 
                {
                    _context.Remove(existOrderDetail);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error DeleteOrderDetail: " + ex.Message);
            }
        }

    }
}
