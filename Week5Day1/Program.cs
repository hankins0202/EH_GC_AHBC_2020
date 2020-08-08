using System;

namespace W5D2_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var circle = new Circle(-1);
                var triangle = new Triangle(3, 4, 5);

                Console.WriteLine(triangle.CalculateArea());
                Console.WriteLine(circle.CalculateArea());
            }
            catch (Exception)
            {
                //telluserto give us a good value
            }
        }
    }
}
