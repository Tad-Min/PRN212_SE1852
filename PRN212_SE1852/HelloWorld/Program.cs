using System.Text;
using System;
   namespace HelloWorld
    {
        class Program
        {   
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Hello, World!");
                Console.WriteLine("I'm FPT student");
                Console.WriteLine("TÔi là Huy");
                double number = 3.14;
                int number2 = 5;
                String name = "Huy";
                var sum = number + name;
                Console.WriteLine($"Sum: {sum}");
                

            Console.ReadKey();
            }
        }
    }




