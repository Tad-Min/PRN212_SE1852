using System;
using System.Text;
namespace FirstDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Hệ phương trình bậc nhất");
            Console.WriteLine("Nhập hệ số a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập hệ số b:");
            double b = Convert.ToDouble(Console.ReadLine());

            if(a == 0 && b == 0)
            {
                Console.WriteLine("Phương trình có vô số nghiệm");
            }
            else if (a == 0 && b!=0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Phương trình có nghiệm x = {x}");
            }


            Console.ReadKey();
        }
    }
}