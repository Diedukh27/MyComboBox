using InheritanceDetails;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("галубци, ДУАВАЙ ");

//var result = Math.Cos(12);

//Console.WriteLine("result {0}", result);

var items = Bolt.GetRoles;
foreach (var item in items)
{
    Console.WriteLine(item);
}
