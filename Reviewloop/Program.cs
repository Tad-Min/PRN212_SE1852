void hinh1(int n)
{
    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < n; j++)
        {
            if (j == 0 || j == n-1 || i==j)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }           
        }
        Console.WriteLine();
    }
}

//hinh1(19);
//Cau 2: sap xep mang tang dan dung do While long nhau

void swap( ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void mysort(int[] arr)
{
    int i = 0;
    int j = i + 1;
    do
    {
        do
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;

        }while (j < arr.Length - 1);
        i++;
        j = i + 1;
    }while (i < arr.Length - 1);
}

int[] arr = { 1, 10, 3, 4, 3, 6, 7, 5, 9, 7 };
mysort(arr);
Console.WriteLine("Mang sau khi sap xep.");
foreach (int i in arr)
{
    Console.Write($"{i}\b");
}
