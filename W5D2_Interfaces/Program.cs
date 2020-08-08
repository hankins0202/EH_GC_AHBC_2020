using System;

namespace W5D2_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularHexagon hexagon = new RegularHexagon(1);
            Triangle triangle = new Triangle(2, 3, 4);
            Circle circle = new Circle(1);

            //Console.WriteLine($"Area of {nameof(RegularHexagon)}: {hexagon.CalculateArea()} and has {hexagon.NumberOfSides} sides.");
            Console.WriteLine($"Area of Circle: {circle.CalculateArea()} and has {circle.NumberOfSides} sides");
            Console.WriteLine($"Area of Triangle: {triangle.CalculateArea()} and has {triangle.NumberOfSides} sides");
        }
    }
}
