using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        Task<List<Customer>?> GetAllCustomers();
        Task<Customer?> GetCustomerById(int id);
        Task<bool> DeleteCustomer(int id);
        Task<bool> UpdateCustomer(Customer customer);
        Task<Customer?> Login(string phone);
    }
}
