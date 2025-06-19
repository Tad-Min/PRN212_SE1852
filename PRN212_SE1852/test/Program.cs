using System.Text;
using test;

static int FuncX(params int[] arr)

{

    int s = 0;

    foreach (int x in arr)

    {

        if (x % 2 == 0)

            s += x;

    }

    return s;

}

#region B1
//Class1 cls = new Class1();

//    cls.X = 5;

//    cls.Y = 7;

//    cls.FunctionA(cls);

//    Console.WriteLine("cls.X=" + cls.X + ";cls.Y=" + cls.Y);

//    Console.ReadLine();
#endregion
#region B2
//A a1 = new A();

//a1.X = 100;

//a1.Y = 200;

//A a2 = new A();

//a2.X = 300;

//a2.Y = 400;

//Console.WriteLine("a1.x=" + a1.X + ",a1.y=" + a1.Y);

//Console.WriteLine("a2.x=" + a2.X + ",a2.y=" + a2.Y);

//Console.ReadLine();
#endregion
#region B3
//int kq = FuncX(5, 6, 7, -1, 4, 3);

//Console.WriteLine(kq);

//Console.ReadLine();
#endregion
#region B4
//Class1 cls = new Class1();

//cls.X = 5;

//cls.Y = 7;

//cls.FunctionA(out cls);

//Console.WriteLine("cls.X=" + cls.X + ";cls.Y=" + cls.Y);

//Console.ReadLine();
#endregion
#region B5

//Y y1 = new Y();

//y1.XuatDuLieu();

//Console.ReadLine();
#endregion
int[] a = { 555, 61,23 , 222, 7 };
var o = Array.BinarySearch(a, 7);
Console.WriteLine(o);
