using SimpleConsoleApplication;

var basicExamples = new BasicExamples();
basicExamples.PrintHelloWorld();
basicExamples.PrintDataTypes();
basicExamples.PrintLoops();
basicExamples.PrintConditionalLogic();

Person person = new Person("Myles", 28, new Greeter());
person.Greet();

person.Age = 29;
//Age is changed
person.Greet();

person.Age = -29;
//Age is not changed as it is negative
person.Greet();

Student student = new Student("John", 18, new Greeter(), "B+");
student.Greet();
