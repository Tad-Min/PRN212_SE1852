using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
namespace DataAccessLayer
{
    public class UserDAO 
    {
        static List<User> users = new List<User>();
        public void InitializeDataset()
        {
            users.Add(new User() { Name = "Tèo", Phone = "0123871301", Email = "teo@gmail.com" });
            users.Add(new User() { Name = "Tí", Phone = "012123301", Email = "ti@gmail.com" });
            users.Add(new User() { Name = "Bin", Phone = "012453301", Email = "bin@gmail.com" });
            users.Add(new User() { Name = "Bo", Phone = "0123123301", Email = "bo@gmail.com" });
            users.Add(new User() { Name = "Kẹo", Phone = "01214431301", Email = "keo@gmail.com" });

        }
        public List<User> GetAllUser()
        {
            return users;
        }


    }
}
