namespace SimpleConsoleApplication;

public class Student (string name, int age, string grade) : Person (name, age), IGreetable
{
    private readonly string _grade = grade;

    public new void Greet()
    {
        Console.WriteLine($"Your grade is {_grade}.");
    }
}