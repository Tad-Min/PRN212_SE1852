void doicho( int a, int b)
{
    int temp = a; a = b; b = temp;
    Console.WriteLine("a = " + a);
    Console.WriteLine("b = " + b);
}

int a = 19;
int b = 8;
 
Console.WriteLine("a = "+ a);
Console.WriteLine("b = "+  b);

doicho (a, b);

