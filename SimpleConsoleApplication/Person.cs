namespace SimpleConsoleApplication;

public class Person(string name, int age, Greeter greeter) : IGreetable
{
    public int Age
    {
        set
        {
            if (value >= 0)
            {
                age = value;
            } 
        }
    }

    public virtual void Greet()
    {
        var greetingString = $"Hello {name} - you are {age} years old.";
        greeter.Greet(greetingString);
    }
}

