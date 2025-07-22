using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerActionService : ICustomerActionService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly ICustomerRepository _customerRepository;

        public CustomerActionService()
        {
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
            _customerRepository = new CustomerRepository();
        }

        public Task<List<Order>?> GetAllOrderByCustmerIdAndSearchById(int? key, int userId)
        {
            return _orderRepository.GetAllOrderByCustmerIdAndSearchById(key, userId);
        }

        public async Task<List<OrderDetail>?> GetAllOrderDetailsByOId(int id)
        {
            return await _orderDetailRepository.GetAllOrderDetailsByOId(id);
        }

        public async Task<Customer?> GetCustomerById(int id)
        {
            return await _customerRepository.GetCustomerById(id);
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            return await _customerRepository.UpdateCustomer(customer);
        }
    }
}
