using System.Text;
using OOP1;

category c1 = new category();
c1.id = 1;
c1.name = "A";
Console.OutputEncoding = Encoding.UTF8;

c1.printInfor();


Staff c2  = new Staff();
c2.Id = 2;
c2.Name = "B";
c2.Email = "b@gmail.com";
c2.Phone = "123456789";

Console.WriteLine($"Staff = {c2.Id},{c2.Name},{c2.Email},{c2.Phone}");

Console.WriteLine("_______________________________________________");

Console.WriteLine(c2);


Staff c3  = new Staff(3,"Tao","Tao@gmail.com","1234567889");

Console.WriteLine(c3);

Staff c4 = new Staff()
{
    Id = 3,
    Name = "La",
    Email = "La@gmail.com",
    Phone = "123456789"
};
Console.WriteLine(c4);