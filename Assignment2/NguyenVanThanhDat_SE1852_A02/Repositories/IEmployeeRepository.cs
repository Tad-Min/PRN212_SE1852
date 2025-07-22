using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IEmployeeRepository
    {
        
        Task<Employee?> Login(string userName, string pwd);
        Task<Employee?> GetEmployeeById(int id);
        Task<bool> UpdateEmpoyee(Employee employee);

    }
}
