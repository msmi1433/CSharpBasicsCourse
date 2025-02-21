namespace SimpleConsoleApplication;

public class Greeter () : IGreetable
{
    public void Greet(string name, int age)
    {
        Console.WriteLine($"Hello {name}, you are {age} years old.");
    }
}