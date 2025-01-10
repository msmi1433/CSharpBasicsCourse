namespace SimpleConsoleApplication;

public class Person(string name, int age)
{
    private readonly string _name = name;
    private int _age = age;

    public void SetAge(int age)
    {
        if (age >= 0)
        {
            _age = age;
        }
    }
    
    public void Greet()
    {
        Console.WriteLine($"Hello {_name}, you are {_age} years old.");
    }
}

