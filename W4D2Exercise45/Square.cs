using System;
namespace W4D2Exercise45
{
    public class Square
    {
        public int SideLength { get; set; }


        public int CalculatePerimeter()
        {
            return SideLength * 4;
        }
        public int CalculateArea()
        {
            return SideLength * SideLength;
        }
        public Square(int sideLength)
        {
            SideLength = sideLength;
        }
    }
}
