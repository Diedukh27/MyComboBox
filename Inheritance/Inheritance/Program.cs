// See https://aka.ms/new-console-template for more information
using Inheritance;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

// Console.WriteLine("Hello, World!");

Console.WriteLine("*******Basic Inheritance********\n");
/*
Car car = new Car(180);

car.Speed = 50;
Console.WriteLine("Мії Автомобиль їде {0} км/нод", car.Speed);
*/

MiniVan miniVan = new MiniVan();
miniVan.Speed = 170;
Console.WriteLine("Мії вен їде {0} км/год", miniVan.Speed);

