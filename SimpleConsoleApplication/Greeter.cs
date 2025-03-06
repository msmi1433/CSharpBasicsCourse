namespace SimpleConsoleApplication;

public class Greeter () : IGreeter 
{
    public void Greet(string greetingString)
    {
        Console.WriteLine(greetingString);
    }
}