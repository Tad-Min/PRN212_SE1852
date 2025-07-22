using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly OrderDetailDAO _orderDetailDAO;
        public OrderDetailRepository()
        {
            _orderDetailDAO = new OrderDetailDAO();
        }
        public OrderDetailRepository(OrderDetailDAO orderDetailDAO)
        {
            _orderDetailDAO = orderDetailDAO;
        }

        public async Task<bool> AddOrderDetail(OrderDetail orderDetail)
        {
            return await _orderDetailDAO.AddOrderDetail(orderDetail);
        }

        public async Task<bool> DeleteOrderDetailByOIdAndPId(int orderId, int productId)
        {
            return await _orderDetailDAO.DeleteOrderDetailByOIdAndPId(orderId, productId);
        }

        public async Task<List<OrderDetail>?> GetAllOrderDetailsByOId(int id)
        {
            return await _orderDetailDAO.GetAllOrderDetailsByOId(id);
        }

        public async Task<OrderDetail?> GetOrderDetailsByOIdAndPIdAsync(int orderId, int productId)
        {
            return await _orderDetailDAO.GetOrderDetailsByOIdAndPIdAsync(orderId, productId);
        }

        public async Task<bool> UpdateOrderDetail(OrderDetail orderDetail)
        {
            return await _orderDetailDAO.UpdateOrderDetail(orderDetail);
        }
    }
}
