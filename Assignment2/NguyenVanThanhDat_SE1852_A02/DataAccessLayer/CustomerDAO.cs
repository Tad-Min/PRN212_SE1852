using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        private readonly LucySalesDataContext _context;
        public CustomerDAO()
        {
            _context = new LucySalesDataContext();
        }

        public CustomerDAO( LucySalesDataContext context)
        {
            _context = context;
        }

        public async Task<Customer?> Login(string phone)
        {
            try
            {
                return await _context.Customers.FirstOrDefaultAsync(x => x.Phone == phone);
            }
            catch (Exception ex) 
            {
                throw new Exception("error Login customer: " + ex.Message);
            }
        }
        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public async Task<List<Customer>?> GetAllCustomers()
        {
            try
            {
                return await _context.Customers.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Error GetAllCustomers: " + ex.Message);
            }
        }

        public async Task<Customer?> GetCustomerById(int id)
        {
            try { 

                return await _context.Customers.FindAsync(id);
            }
            catch(Exception ex)
            {
                throw new Exception("Error GetCustomerById: " + ex.Message);
            }
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            try
            {
                _context.Customers.Update(customer);
                await _context.SaveChangesAsync();
                return true;

            }
            catch(Exception ex)
            {
                throw new Exception("Error UpdateCustomer: " + ex.Message);
            }
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            try
            {
                var customer = _context.Customers.Find(id);
                if (customer != null)
                {
                    _context.Customers.Remove(customer);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error DeleteCustomer: " + ex.Message);
            }
            
        }

        public async Task<List<Customer>?> SearchCustomers(string keyword)
        {
            try
            {
                return await _context.Customers
                .Where(c => c.ContactName.Contains(keyword))
                .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error SearchCustomers: " + ex.Message);
            }
            
        }
    }
}

