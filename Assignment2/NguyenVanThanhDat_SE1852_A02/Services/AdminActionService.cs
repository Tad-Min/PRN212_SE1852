using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AdminActionService : IAdminActionService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICustomerRepository _customerRepository;

        public AdminActionService()
        {
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
            _employeeRepository = new EmployeeRepository();
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
            _customerRepository = new CustomerRepository();
        }
        public AdminActionService(IOrderRepository orderRepository,
            IOrderDetailRepository orderDetailRepository,
            IEmployeeRepository employeeRepository,
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            ICustomerRepository customerRepository)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _employeeRepository = employeeRepository;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _customerRepository = customerRepository;
        }

        #region Report
        public Task<List<Order>?> GenerateReport(DateTime startDate, DateTime endDate)
        {
            return _orderRepository.GetAllOrdersInDate(startDate, endDate);
        }

        public async Task<List<Order>?> GetAllReport()
        {
            return await _orderRepository.GetAllOrders();
        }

        
        #endregion

        #region product
        public async Task<bool> AddProduct(Product product)
        {
            return await _productRepository.AddProductAsync(product);
        }

        public async Task<bool> DeleteProductById(int id)
        {
            return await _productRepository.DeleteProduct(id);
        }

        public async Task<List<Product>?> GetAllProducts(string productName)
        {
            return await _productRepository.GetAllProducts(productName);
        }

        public async Task<Product?> GetProductById(int id)
        {
            return await _productRepository.GetProductById(id);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            return await _productRepository.UpdateProduct(product);
        }
        public async Task<List<Category>?> GetAllCategories()
        {
            return await _categoryRepository.GetAllCategories();
        }
        #endregion

        #region profile
        public async Task<Employee?> GetProfileId(int id)
        {
            return await _employeeRepository.GetEmployeeById(id);
        }

        

        public async Task<bool> UpdateProfile(Employee employee)
        {
            return await _employeeRepository.UpdateEmpoyee(employee);
        }

        #endregion

        #region order
        public async Task<bool> DeleteOrder(int id)
        {
            return await _orderRepository.DeleteOrder(id);
        }
        public async Task<bool> UpdateOrder(Order order)
        {
            return await _orderRepository.UpdateOrder(order);
        }
        public async Task<Order?> GetOrderById(int id)
        {
            return await _orderRepository.GetOrderById(id);
        }
        public async Task<List<Order>?> GetAllOrders()
        {
            return await _orderRepository.GetAllOrders();
        }
        public async Task<bool> AddOrder(Order order)
        {
            return await _orderRepository.AddOrder(order);
        }

        public async Task<bool> DeleteOrderDetailByOIdAndPId(int orderId, int productId)
        {
            return await _orderDetailRepository.DeleteOrderDetailByOIdAndPId(orderId, productId);
        }
        public async Task<bool> UpdateOrderDetail(OrderDetail orderDetail)
        {
            return await _orderDetailRepository.UpdateOrderDetail(orderDetail);
        }
        public async Task<bool> AddOrderDetail(OrderDetail orderDetail)
        {
            return await _orderDetailRepository.AddOrderDetail(orderDetail);
        }
        public async Task<OrderDetail?> GetOrderDetailsByOIdAndPIdAsync(int orderId, int productId)
        {
            return await _orderDetailRepository.GetOrderDetailsByOIdAndPIdAsync(orderId, productId);
        }
        public async Task<List<OrderDetail>?> GetAllOrderDetailsByOId(int id)
        {
            return await _orderDetailRepository.GetAllOrderDetailsByOId(id);
        }
        #endregion

        #region Customer
        public async Task<List<Customer>?> GetAllCustomers()
        {
            return await _customerRepository.GetAllCustomers();
        }
        public async Task<Customer?> GetCustomerById(int id)
        {
            return await _customerRepository.GetCustomerById(id);
        }
        public async Task<bool> DeleteCustomer(int id)
        {
            return await _customerRepository.DeleteCustomer(id);
        }
        public async Task<bool> UpdateCustomer(Customer customer)
        {
            return await _customerRepository.UpdateCustomer(customer);
        }
        #endregion

    }
}
