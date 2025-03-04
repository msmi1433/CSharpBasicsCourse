namespace SimpleConsoleApplication;

public class BasicExamples
{
    int integerExample = 3;
    string stringExample = "Goodbye, world!";
    bool booleanExample = true;
    double doubleExample = 3.3333333D;
    char charExample = 'C';

    private bool IsEven(int integer)
    {
        return integer % 2 == 0;
    }

    public void PrintHelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }

    public void PrintDataTypes()
    {
        Console.WriteLine("Here are some examples of the basic data types in C#");
        Console.WriteLine();
        Console.WriteLine($"This is an integer: '{integerExample}'");
        Console.WriteLine($"Here is a string: '{stringExample}'");
        Console.WriteLine($"Booleans can be 'False' or: '{booleanExample}'");
        Console.WriteLine($"Finally, a double: '{doubleExample}'");
        Console.WriteLine();
        Console.WriteLine($"As a bonus, here is a char: '{charExample}'");
    }

    public void PrintLoops()
    {
        Console.WriteLine("The below is an example of the various loops available in C#");
        Console.WriteLine();

        Console.WriteLine("For loop:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        int whileLoopInteger = 1;
        Console.WriteLine("While loop:");
        while (whileLoopInteger <= 10)
        {
            Console.WriteLine(whileLoopInteger);
            whileLoopInteger += 1;
        }
        Console.WriteLine();

        int doWhileLoopInteger = 1;
        Console.WriteLine("Do-while loop:");
        do
        {
            Console.WriteLine(doWhileLoopInteger);
            doWhileLoopInteger += 1;
        } while (doWhileLoopInteger <= 10);
        Console.WriteLine();
    }

    public void PrintConditionalLogic()
    {
        Console.WriteLine("This for loop implements an isEven(int) method to declare whether a number is odd or even");
        for (int i = 1; i <= 10; i++)
        {
            string iParity = IsEven(i) ? "even" : "odd";
            Console.WriteLine($"{i} - {iParity}");
        }
        Console.WriteLine();

        Console.WriteLine("You can also use the ternary (?) operator for conditional logic as follows:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(IsEven(i) ? $"{i} - even" : $"{i} - odd");
        }
    }
    
}