using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        Task<bool> DeleteOrder(int id);
        Task<bool> UpdateOrder(Order order);
        Task<Order?> GetOrderById(int id);
        Task<List<Order>?> GetAllOrders();
        Task<bool> AddOrder(Order order);
        Task<List<Order>?> GetAllOrdersInDate(DateTime startDate, DateTime endDate);

        Task<List<Order>?> GetAllOrderByCustmerIdAndSearchById(int? key, int userId);
    }
}
