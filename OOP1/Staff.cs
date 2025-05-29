using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Staff
    {
        #region Nhóm các thuộc tính của Staff
        private int id;
        private string name;
        private string email;
        private string phone;
        #endregion
        public Staff()
        {
            const double pi = 3.14;
        }

        #region Khởi tạo của Staff 
        public Staff(int id, string name, string email, string phone)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
        #endregion
        #region Setter và getter của Stafff 
        public int Id { get { return id; } set {id = value;} }
        public string Name { get { return  name; } set {name = value;} }
        public string Email { get { return email; } set {email = value;} }
        public string Phone { get { return phone; } set {phone = value;} }
        #endregion
        public void printInfor()
        {
            Console.WriteLine($"{id} \t {name} \t {email} \t {phone}");
        }

        public override string ToString()
        {
            string mess = $"{id} \t {name} \t {email} \t {phone}";
            return mess;
        }
            
    }
}
