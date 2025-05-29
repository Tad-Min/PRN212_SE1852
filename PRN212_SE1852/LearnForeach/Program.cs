int sum(params int[] arr)
{
    int s = 0;
    foreach (int i in arr)
    {
        Console.Write(i);
        System.Threading.Thread.Sleep(100);
    }
    return s;
}

int s = sum(1,2,3,4,5,5,6,7);
Console.WriteLine(s);

