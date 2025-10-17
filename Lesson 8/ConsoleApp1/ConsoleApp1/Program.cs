// See https://aka.ms/new-console-template for more information


using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


// Console.WriteLine("Hello, World!");

Person p = new Student("Oleg", 20, "Kyiv University");
p.PrintInfo();

Person dima = new ScoolStudent("Dima", 14, "Lviv School");
dima.PrintInfo();



