public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name = "Unknown", int age = 0)
    {
        Name = name;
        Age = age;
    }

    // Віртуальний метод для перевизначення у наслідниках
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Person: {Name}, Age: {Age}");
    }
}

