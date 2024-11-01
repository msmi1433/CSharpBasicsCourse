namespace SimpleConsoleApplication;

public class Person
{
    void Main(string name, int age)
    {
        Name = name;
        Age = age;
        
        Greet();
    }
    
    private string Name;
    private int Age;
    private void Greet()
    {
        Console.WriteLine($"Hello {Name}, you are {Age} years old.");
    }
}