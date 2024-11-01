namespace SimpleConsoleApplication;

public class Person(string name, int age)
{
    private readonly string _name = name;
    private readonly int _age = age;
    
    public void Greet()
    {
        Console.WriteLine($"Hello {_name}, you are {_age} years old.");
    }
}

