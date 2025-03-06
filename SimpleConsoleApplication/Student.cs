namespace SimpleConsoleApplication;

public class Student (string name, int age, Greeter greeter, string grade) : Person (name, age, greeter)
{ 
    public override void Greet()
    {
        var greetingString = $"Hello {Name} - you are {Age} years old. Your grade is {grade}";
        Greeter.Greet(greetingString);
        
    }
}