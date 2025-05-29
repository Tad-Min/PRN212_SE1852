using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class category
    {
        public int id;
        public string name;

        public void printInfor()
        {
            Console.WriteLine($"{id}\t {name}");
        }


    }
}
