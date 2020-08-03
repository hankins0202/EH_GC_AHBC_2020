using System;
namespace Exercise46
{
    public class Triangle
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }


        public Triangle(int side1length, int side2length, int side3length)
        {
            Side1Length = side1length;
            Side2Length = side2length;
            Side3Length = side3length;
        }

        public int CalculatePerimeter ()
        {
            return Side1Length + Side2Length + Side3Length;
        }

        public int CalculateArea()
        {
            //int s = (Side1Length + Side2Length + Side3Length) / 2;
            var s = CalculatePerimeter() / 2; //s is semiPerimeter
            
            var area = (int)Math.Sqrt(s*(s-Side1Length)*(s-Side2Length)*(s-Side3Length));
            return area; 
        }

    }
}
/* Math.Sqrt is part of the math library and C# has access to it
 * Casting = (int) squareroot converts double into int.
 * Good good friend.  Google knows everything.*/