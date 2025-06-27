using BusinessObjects;
using Repositories;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public void InitializeDataset()
        {
            _customerRepository.InitializeDataset();
        }

        public Customer? GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public Customer? GetCustomerByPhone(string phone)
        {
            return _customerRepository.GetCustomerByPhone(phone);
        }

        public bool SaveCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.CompanyName) || string.IsNullOrWhiteSpace(customer.Phone))
            {
                return false;
            }

            if (_customerRepository.GetCustomerByPhone(customer.Phone) != null)
            {
                return false;
            }

            return _customerRepository.SaveCustomer(customer);
        }

        public bool UpdateCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.CompanyName) || string.IsNullOrWhiteSpace(customer.Phone))
            {
                return false;
            }

            return _customerRepository.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }

        public List<Customer> SearchCustomers(string keyword)
        {
            return _customerRepository.SearchCustomers(keyword);
        }
    }
}
