/*
    Ứng dụng Generic để quản lý nhân viên, thực hiện các thao tác CRUD 
    C - Create -> Thêm mới
    R - Read -> Truy vấn xem sắp xếp, lọc
    U - Update -> Chỉnh sửa dữ liệu
    D - Delete -> Xóa dữ liệu
 */

using OOP2;

List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    Name = "Name 1",
    IdCard ="123",
    Birthday = new DateTime(1980, 1, 1)
};
FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    Name = "Name 2",
    IdCard = "456",
    Birthday = new DateTime(1983, 9, 11)
};
FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    Name = "Name 3",
    IdCard = "789",
    Birthday = new DateTime(1993, 9, 27)
};

FulltimeEmployee fe4 = new FulltimeEmployee()
{
    Id = 4,
    Name = "Name 4",
    IdCard = "321",
    Birthday = new DateTime(1992, 3, 10)
};

ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 5,
    Name = "Name 5",
    IdCard = "654",
    Birthday = new DateTime(1999, 5, 15),
    WorkingHours = 10 // Số giờ làm việc
};
employees.Add(fe1);
employees.Add(fe2);
employees.Add(fe3);
employees.Add(fe4);
employees.Add(pe1);

//Câu 2: xuất toàn bộ thông tin nhân sự (R)
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Thông tin toàn bộ nhân sự:");

//Cách 1: Dùng Expression body (Lambda Expression)
employees.ForEach(employee => Console.WriteLine(employee));

//Cách 2: Dùng for thong thường (ko dùng =>)
Console.WriteLine("===========Cách for thông thường");
foreach(var e in employees)
{
    Console.WriteLine(e);
}

//Câu 3: Sắp xếp nhân viên theo năm sinh tăng dần.
//Cũng là R-Read/Retrieve

for (int i = 0; i < employees.Count; i++)
{
    for (int j = i+1; j<employees.Count; j++)
    {
        if (employees[i].Birthday.Year > employees[j].Birthday.Year)
        {
            var temp = employees[i];
            employees[i] = employees[j];
            employees[j] = temp;
        }
    }
}

Console.WriteLine("-----------Employee sau khi sắp xếp---------------");
employees.ForEach(e => Console.WriteLine(e));