namespace SimpleConsoleApplication;

public class Student (string name, int age, string grade) : Person (name, age)
{
    private readonly string _grade = grade;

    public override void Greet()
    {
        var greeter = new Greeter();
        greeter.Greet(name, age, _grade);
    }
}