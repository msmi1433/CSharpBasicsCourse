namespace SimpleConsoleApplication;

public class Student (string name, int age, Greeter greeter, string grade) : Person (name, age, greeter)
{ 
    public override void Greet()
    {
        var greetingString = $"Hello {name} - you are {age} years old. Your grade is {grade}";
        greeter.Greet(greetingString);

    }
}