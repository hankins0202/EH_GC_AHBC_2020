using System;

namespace Week2Day1
{
    class Program
    {
        private static void Main(string[] args) //Method signature in class program.  Void is referring to the return of nothing. Break up code into actionable items. Static is referring to access level, declare type, name, public static void doSomething().  Static is special part of access, to talk in another lecture. Console app typically always in static. Bad programming to not put in accessing, private, public, protected. 
        {
            //Cannot put a method inside another method
        
            Console.WriteLine("Please input a number");
            var inputone = Console.ReadLine();
            Console.WriteLine("Please input another number");
            var inputtwo = Console.ReadLine();

            var example19 = new Example19();
            var result = example19.SumUserInputs(int.Parse(inputone), int.Parse(inputtwo));
            
            Console.WriteLine($"Here is the sum of numbers: {result}");

        }
    }
}
