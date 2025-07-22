using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IAuthService
    {
        Task<Customer?> Login(string phone);
        Task<Employee?> Login(string userName, string pwd);
    }
}
