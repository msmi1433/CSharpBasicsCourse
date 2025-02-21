namespace SimpleConsoleApplication;

public class Person(string name, int age, IGreetable greeter)
{
    private readonly string _name = name;
    private int _age = age;

    public int Age
    {
        set
        {
            if (value >= 0)
            {
                _age = value;
            } 
        }
    }

    public virtual void Greet()
    {
        greeter.Greet(_name, _age);
    }
}

