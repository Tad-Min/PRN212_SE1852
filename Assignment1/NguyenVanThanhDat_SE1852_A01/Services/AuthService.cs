using BusinessObjects;
using DataAccessLayer;
using Repositories;

namespace Services
{
    public class AuthService : IAuthService
    {
        private readonly ICustomerRepository _customerRepository;
        private Employee? _currentEmployee;
        private Customer? _currentCustomer;

        private static readonly List<Employee> _employees = new EmployeeDAO().GetAllEmployeessWithInitializeDataset();

        public AuthService()
        {
            _customerRepository = new CustomerRepository();
            _customerRepository.InitializeDataset();
        }

        public Employee? EmployeeLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            var employee = _employees.FirstOrDefault(e => e.UserName == username && e.Password == password);
            if (employee != null)
            {
                _currentEmployee = employee;
                _currentCustomer = null;
            }
            return employee;
        }

        public Customer? CustomerLogin(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return null;
            }

            var customer = _customerRepository.GetCustomerByPhone(phone);
            if (customer != null)
            {
                _currentCustomer = customer;
                _currentEmployee = null;
            }
            return customer;
        }

        public bool IsEmployeeLoggedIn()
        {
            return _currentEmployee != null;
        }

        public bool IsCustomerLoggedIn()
        {
            return _currentCustomer != null;
        }

        public Employee? GetCurrentEmployee()
        {
            return _currentEmployee;
        }

        public Customer? GetCurrentCustomer()
        {
            return _currentCustomer;
        }

        public void Logout()
        {
            _currentEmployee = null;
            _currentCustomer = null;
        }
    }
}
