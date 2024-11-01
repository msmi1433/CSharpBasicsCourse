namespace SimpleConsoleApplication;

public class Person
{
    private string Name;
    private int Age;
    private void Greet()
    {
        Console.WriteLine($"Hello {Name}, you are {Age} years old.");
    }
}