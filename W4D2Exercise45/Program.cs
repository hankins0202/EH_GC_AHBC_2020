using System;

namespace W4D2Exercise45 //Justin and Elizabeth
{
    class Program
    {


        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter a side length:");
                var userInput = int.Parse(Console.ReadLine());

                Square square = new Square(userInput);

                var perimeter = square.CalculatePerimeter();
                var area = square.CalculateArea();

                Console.WriteLine($"The square has side length {square.SideLength}. Its area is {area} and its perimeter is {perimeter}");
                Console.WriteLine("Would you like to continue. Press n to quite, any other key to continue.");
                var again = Console.ReadLine();
                if (again.ToLower().Equals("n"))
                {
                    return;
                }

            }
        }
    }
}
