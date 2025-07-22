using BusinessObjects;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICustomerActionService
    {
        Task<List<Order>?> GetAllOrderByCustmerIdAndSearchById(int? key, int userId);
        Task<List<OrderDetail>?> GetAllOrderDetailsByOId(int id);

        Task<Customer?> GetCustomerById(int id);
        Task<bool> UpdateCustomer(Customer customer);
    }
}
