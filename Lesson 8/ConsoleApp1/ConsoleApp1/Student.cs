public class Student : Person
{
    public string University { get; set; }

    public Student(string name = "Student", int age = 18, string university = "Unknown") : base(name, age)
    {
        University = university;
    }

    // Перевизначення методу
    public override void PrintInfo()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}, University: {University}");
    }
}

