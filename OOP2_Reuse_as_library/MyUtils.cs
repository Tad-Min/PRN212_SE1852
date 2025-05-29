using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Reuse_as_library
{
    public static class MyUtils
    {
        public static int TinhTuoi(this Employee emp)
        {
            if (emp == null)
            {
                return 0;
            }
            else
            {
                DateTime today = DateTime.Now;
                int age = today.Year - emp.Birthday.Year;
                if (today.Month < emp.Birthday.Month || (today.Month == emp.Birthday.Month && today.Day < emp.Birthday.Day))
                {
                    age--;
                }
                return age;
            }
        }
    }
}
