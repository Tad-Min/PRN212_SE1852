using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDAO _orderDAO = new OrderDAO();
        public async Task<bool> AddOrder(Order order)
        {
            return await _orderDAO.AddOrder(order);
        }

        public async Task<bool> DeleteOrder(int id)
        {
            return await _orderDAO.DeleteOrder(id);
        }


        public async Task<List<Order>?> GetAllOrders()
        {
            return await _orderDAO.GetAllOrders();
        }

        public async Task<List<Order>?> GetAllOrdersInDate(DateTime startDate, DateTime endDate)
        {
            return await _orderDAO.GetAllOrdersInDate(startDate, endDate);
        }

        public async Task<Order?> GetOrderById(int id)
        {
            return await _orderDAO.GetOrderById(id);
        }

        public async Task<bool> UpdateOrder(Order order)
        {
            return await _orderDAO.UpdateOrder(order);
        }

        public async Task<List<Order>?> GetAllOrderByCustmerIdAndSearchById(int? key, int userId)
        {
            return await _orderDAO.GetAllOrderByCustmerIdAndSearchById(key, userId);
        }
    }
}
