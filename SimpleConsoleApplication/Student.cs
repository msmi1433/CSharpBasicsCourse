namespace SimpleConsoleApplication;

public class Student (string name, int age, IGreetable greeter, string grade) : Person (name, age, greeter)
{
    private readonly string _grade = grade;

    public override void Greet()
    {
        base.Greet();
        Console.WriteLine($"Your grade is {_grade}.");
    }
}