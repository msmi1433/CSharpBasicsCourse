namespace SimpleConsoleApplication;

public class Greeter : IGreetable
{
   public void Greet(string name, int age, string? grade = null)
   {
      if (grade == null)
      {
         Console.WriteLine($"Hello {name}, you are {age} years old.");
      }
      else
      {
         Console.WriteLine($"Hello {name}, you are {age} years old. Your grade is {grade}.");
      }
   }
}
