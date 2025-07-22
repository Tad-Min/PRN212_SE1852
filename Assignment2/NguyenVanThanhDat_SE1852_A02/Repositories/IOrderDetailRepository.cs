using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        Task<bool> DeleteOrderDetailByOIdAndPId(int orderId, int productId);
        Task<bool> UpdateOrderDetail(OrderDetail orderDetail);
        Task<bool> AddOrderDetail(OrderDetail orderDetail);
        Task<OrderDetail?> GetOrderDetailsByOIdAndPIdAsync(int orderId, int productId);
        Task<List<OrderDetail>?> GetAllOrderDetailsByOId(int id);
    }
}
