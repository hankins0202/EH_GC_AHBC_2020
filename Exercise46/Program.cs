using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise46
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter side lengths of a triangle: ");
                string sides = Console.ReadLine();
                List<int> TriangleSideList = sides.Split(' ').Select(int.Parse).ToList();
                Console.WriteLine(TriangleSideList);
                int side1length = TriangleSideList[0];
                int side2length = TriangleSideList[1];
                int side3length = TriangleSideList[2];

                Triangle triangle = new Triangle(side1length, side2length, side3length);
                //int perimeter = triangle.CalculatePerimeter();  //code that is not needed because we can call the class and method in the print line.
                //int Area = triangle.CalculateArea();

                Console.WriteLine($"The triangle has side lengths {side1length}, {side2length}, and {side3length}. Its area is {triangle.CalculateArea()} and its perimeter is {triangle.CalculatePerimeter()}");
                Console.WriteLine("Would you like to continue? n for no and all other keys for yes");
                var again = Console.ReadLine();
                if (again.ToLower().Equals("n"))
                {
                    return;
                }

            }
        }
    }
}
