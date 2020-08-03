using System;

namespace W4D2Exercise42// and 43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X point");
            var xPoint = Console.ReadLine();
            Console.WriteLine("Enter Y point");
            var yPoint = Console.ReadLine();

            var point = new Point(xPoint, yPoint);//instatiated object and saved to memory.  Initialized. "xPoint" and "yPoint" are being passed through the class into Class Point similar to method parameters. The constructor is obstaniating it. Passing values into the constructor is another. While we are here abstaniate it in the class.
            Console.WriteLine($"Here is the Xpoint {point.X}, and Ypoint {point.Y}.");//X and Y should be same values that users entered
        }
    }
}


/* 1. User passed in. Line 14 is a new object "Point".
 * 2. Constructor there to create objects, Values that user entered
 * 3. Within scope of constructor assignins/"setting" value to properties
 * 4. Object is created and obstaniated.  Values are stored in memory.
 * 5.Line 15 is "getting" the property to return the value that was stored in memory
 * 
 * Note: Set method happens before Get method in property.
 * M stands for method, P stand for property.  dot brings up menu of objects.*/