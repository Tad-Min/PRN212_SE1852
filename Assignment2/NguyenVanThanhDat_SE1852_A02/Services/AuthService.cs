using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AuthService : IAuthService
    {        
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmployeeRepository _employeeRepository;
        public AuthService()
        {
            _customerRepository = new CustomerRepository();
            _employeeRepository = new EmployeeRepository();
        }
        public AuthService(ICustomerRepository customerRepository, IEmployeeRepository employeeRepository)
        {
            _customerRepository = customerRepository;
            _employeeRepository = employeeRepository;
        }

        public async Task<Customer?> Login(string phone)
        {
            return await _customerRepository.Login(phone) ?? null;
        }

        public async Task<Employee?> Login(string userName, string pwd)
        {
            return await _employeeRepository.Login(userName, pwd) ?? null;
        }
    }
}
