using System.Text;

String firstname = "Nguyen";
String midname = "Gia";
String lastname = "Huy";
StringBuilder sb = new StringBuilder();
sb.Append(firstname);
sb.Append(' ');
sb.Append(midname);
sb.Append(" ");
sb.Append(lastname);
String fullname = sb.ToString();
Console.WriteLine(fullname);
Console.ReadKey(); 