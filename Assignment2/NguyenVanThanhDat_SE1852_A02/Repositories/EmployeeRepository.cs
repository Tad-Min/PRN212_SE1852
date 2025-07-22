using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDAO _employeeDAO;
        public EmployeeRepository() 
        {
            _employeeDAO = new EmployeeDAO();
        }

        public EmployeeRepository(EmployeeDAO employeeDAO)
        {
            _employeeDAO = employeeDAO;
        }

        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await _employeeDAO.GetEmployeeById(id);
        }

        public async Task<Employee?> Login(string userName, string pwd)
        {
            return await _employeeDAO.Login(userName, pwd);
        }

        public async Task<bool> UpdateEmpoyee(Employee employee)
        {
            return await _employeeDAO.UpdateEmpoyee(employee);
        }
    }
}
