using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeDAO
    {
        private readonly LucySalesDataContext _context;
        public EmployeeDAO()
        {
            _context = new LucySalesDataContext();
        }
        public EmployeeDAO(LucySalesDataContext context)
        {
            _context = context;
        }

        public async Task<Employee?> Login(string userName, string pwd)
        {
            try
            {
                return await _context.Employees.FirstOrDefaultAsync(x => x.UserName == userName && x.Password == pwd);
            }
            catch(Exception ex)
            {
                throw new Exception("Error Emloyee Login: " + ex.Message);
            }
        }

        public async Task<Employee?> GetEmployeeById(int id)
        {
            try
            {
                return await _context.Employees.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error GetEmployeeById: " + ex.Message);
            }
        }

        public async Task<bool> UpdateEmpoyee(Employee employee) 
        {
            try
            {
                var exist = await _context.Employees.FindAsync(employee.EmployeeId);
                if (exist != null) 
                {
                    _context.Employees.Update(employee);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception("Error UpdateEmpoyee: " + ex.Message);
            }
        }
    }
}
