using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
        List<User> GetAllUsers();
    }
}
