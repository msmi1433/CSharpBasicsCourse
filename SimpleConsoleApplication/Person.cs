namespace SimpleConsoleApplication;

public class Person(string name, int age,  IGreeter greeter) : IGreetable
{
    protected string Name { get; } = name;
    public int Age
    {
        get => age;
        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }
    protected readonly IGreeter Greeter = greeter;

    public virtual void Greet()
    {
        var greetingString = $"Hello {Name} - you are {age} years old.";
        Greeter.Greet(greetingString);
    }
}

