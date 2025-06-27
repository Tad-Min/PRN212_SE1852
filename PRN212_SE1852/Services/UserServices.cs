using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserServices()
        {
            _userRepository = new UserRepository();
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
    }
}
