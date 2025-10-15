using System.Text;
using System.Collections;
using ExeptionCollection;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


int[] myArray = { 19, 39, 69 };
foreach (int i in myArray)
{
    Console.WriteLine("{0}\t", i);
}

ArrayList myArrayList = new ArrayList();
myArrayList.Add(19);
myArrayList.Add("Білочка");
myArrayList.Add(true);
myArrayList.Add(3.52);

foreach (var item in myArrayList)
{
    Console.Write("{0}\t",item);
}Console.WriteLine();


object myObject = "Hello my Friend";
Console.WriteLine(myObject);

Console.WriteLine("-----My Array Custom-----");

MyGeneric stepan =  new MyGeneric();

stepan.Add("Альона");
stepan.Add("Мальвіна");
stepan.Add(18);
stepan.Add(52);

stepan.ViewItems();

int index = stepan.SearchIndex(18);
Console.WriteLine("SEarch index =", + index);