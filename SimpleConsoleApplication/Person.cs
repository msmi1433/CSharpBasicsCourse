namespace SimpleConsoleApplication;

public class Person(string name, int age)
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

    public void Greet()
    {
        var greeter = new Greeter();
        greeter.Greet(_name, _age);
    }
}

