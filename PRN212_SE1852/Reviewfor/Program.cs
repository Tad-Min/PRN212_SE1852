using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n;
Console.WriteLine("Nhap n >= 0 ");
String s = Console.ReadLine();
if (int.TryParse(s, out n) == false)
{
    Console.WriteLine("May cho tao 1 con so");
}
else
{
    if(n < 0)
    {
        Console.WriteLine("Tao can con so lon hon 0");
    }
    else
    {
        int gt = 1;
        for (int i = 1; i <= n; i++)
        {
            gt = gt * i;
        }
        Console.WriteLine($"{n}! = {gt}");
    }
}
