using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeDAO
    {
        static List<Employee> employees = new List<Employee>();
        public void InitializeDataset()
        {
            if (employees.Count >0) return;

            employees.Add(new Employee { EmployeeId = 1, Name = "Nancy Davolio", UserName = "Nancy", Password = "123", JobTitle = "Sales Representative" });
            employees.Add(new Employee { EmployeeId = 2, Name = "Andrew Fuller", UserName = "Andrew", Password = "456", JobTitle = "Vice President, Sales" });
            employees.Add(new Employee { EmployeeId = 3, Name = "Janet Leverling", UserName = "Janet", Password = "789", JobTitle = "Sales Representative" });
            employees.Add(new Employee { EmployeeId = 4, Name = "Margaret Peacock", UserName = "Margaret", Password = "321", JobTitle = "Sales Representative" });
            employees.Add(new Employee { EmployeeId = 5, Name = "Steven Buchanan", UserName = "Steven", Password = "654", JobTitle = "Sales Manager" });
            employees.Add(new Employee { EmployeeId = 6, Name = "Michael Suyama", UserName = "Michael", Password = "987", JobTitle = "Sales Representative" });
            employees.Add(new Employee { EmployeeId = 7, Name = "Robert King", UserName = "Robert", Password = "113", JobTitle = "Sales Representative" });
            employees.Add(new Employee { EmployeeId = 8, Name = "Laura Callahan", UserName = "Laura", Password = "114", JobTitle = "Inside Sales Coordinator" });
            employees.Add(new Employee { EmployeeId = 9, Name = "Anne Dodsworth", UserName = "Anne", Password = "115", JobTitle = "Sales Representative" });
            employees.Add(new Employee { EmployeeId = 10, Name = "Dat", UserName = "a", Password = "a", JobTitle = "admin" });
        }

        public List<Employee> GetAllEmployeessWithInitializeDataset()
        {
            InitializeDataset();
            return employees;
        }
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
    }
}
