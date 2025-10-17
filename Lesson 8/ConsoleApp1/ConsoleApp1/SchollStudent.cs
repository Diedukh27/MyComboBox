public class ScoolStudent : Person
{
    public string SchoolName { get; set; }

    public ScoolStudent(string name = "School Student", int age = 15, string schoolName = "Unknown School") : base(name, age)
    {
        SchoolName = schoolName;
    }

    // Метод можна не перевизначати - буде викликатись базовий Person.PrintInfo()
    // Але можна зробити, якщо хочеш
    public override void PrintInfo()
    {
        Console.WriteLine($"SchoolStudent: {Name}, Age: {Age}, School: {SchoolName}");
    }
}

