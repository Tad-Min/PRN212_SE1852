using OOP2_ExtendtionMethod;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int n1 = 5;
int n2 = 10;

Console.WriteLine($"Tổng từ 1 tới {n1} là: {n1.TongTu1ToiN()}");
Console.WriteLine($"Tổng từ 1 tới {n2} là: {n2.TongTu1ToiN()}");

int[] M = new int[10];
M.TaoMangNgauNhien();
Console.WriteLine("Mang truoc khi sap xep");
M.XuatMang();
Console.WriteLine("Mang sau khi sap xep");
M.SapXepTangDan();
M.XuatMang();