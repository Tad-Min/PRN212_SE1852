using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDAO _customerDAO;
        public CustomerRepository() 
        {
            _customerDAO = new CustomerDAO();
        }
        public CustomerRepository(CustomerDAO customerDAO)
        {
            _customerDAO = customerDAO;
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            return await _customerDAO.DeleteCustomer(id);
        }

        public async Task<List<Customer>?> GetAllCustomers()
        {
            return await _customerDAO.GetAllCustomers();
        }

        public async Task<Customer?> GetCustomerById(int id)
        {
            return await _customerDAO.GetCustomerById(id);
        }

        public async Task<Customer?> Login(string phone)
        {
            return await _customerDAO.Login(phone);
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            return await _customerDAO.UpdateCustomer(customer);
        }
    }
}
