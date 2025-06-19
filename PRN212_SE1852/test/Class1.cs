using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Class1

    {
        #region B1
        //public int X { get; set; }

        //public int Y { get; set; }

        //public void FunctionA(Class1 cls)

        //{

        //    cls = new Class1();

        //    cls.X = 100;

        //    cls.Y = 200;

        //}
        #endregion

        public int X { get; set; }

        public int Y { get; set; }

        public void FunctionA(out Class1 cls)

        {

            cls = new Class1();

            cls.X = 100;

            cls.Y = 200;

        }
    }
}
