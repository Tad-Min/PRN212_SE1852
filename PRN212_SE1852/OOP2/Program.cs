using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee teo = new FulltimeEmployee();
teo.Id = 1;
teo.Name = "Teo";
Console.WriteLine(teo.calSalary());

ParttimeEmployee ty = new ParttimeEmployee();
ty.WorkingHours = 2;
ty.Name = "Ty";
ty.Id = 2;

Console.WriteLine($"luong cua ty = {ty.calSalary()}");

FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 100,
    Name = "Obama",
    IdCard = "123",
    Birthday = new DateTime(1960, 1, 25)
};
Console.WriteLine("============Thong tin Obama=========");
Console.WriteLine(obama.ToString());

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 200,
    Name = "Donald Trump",
    IdCard = "456",
    Birthday = new DateTime(1940, 12, 26),
    WorkingHours = 3
};

Console.WriteLine("============Thong tin Donald Trump=========");
Console.WriteLine(trump.ToString());

