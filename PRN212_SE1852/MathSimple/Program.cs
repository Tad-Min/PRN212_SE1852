using System.Runtime.ConstrainedExecution;
using System.Text;

string do_math(double a, double b, char c)
{
    String result = " ";
    switch(c)
    {
        case '+':
            result = a + "+" + b + "=" + (a + b);
            break;
        case '-':
            result = a + "-" + b + "=" + (a - b);
            break;
        case '*':
            result = a + "*" + b + "=" + (a * b);
            break;
        case '/':
            if (b == 0)
            {
                Console.WriteLine("Vo nghiem");
            }
            else
            {
                result = a + "/" + b + "=" + (a / b);
            }
            break;
        default:
            Console.WriteLine("Wrong");
            break;

    }
    return result;
}

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Nhap a");
double a  = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap b");
double b = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap c");
char c = Char.Parse(Console.ReadLine());
do_math(a, b, c);

Console.ReadKey();