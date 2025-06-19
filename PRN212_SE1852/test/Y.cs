using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Y : X

    {

        public Y() : base(5)

        {

        }

        public Y(int a) : base(a)

        {

        }

        public void XuatDuLieu()

        {

            Console.WriteLine(this.a);

        }
    }

}
