// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
try
{
Console.WriteLine("Скільки вам років");
Console.WriteLine("-->");
string text = Console.ReadLine();
int age = int.Parse(text);
    if (age <= 0)
    {
        throw new Exception("Ви ще не народились нєма прав писать мир не згенероваий ");
    }
Console.WriteLine($"Ваш вік: {age}");
}
catch (FormatException fex) 
{
    Console.WriteLine("Дані було введено не вірно {0}", fex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Х'юстон і нас проблеми {0}", ex.Message);
}