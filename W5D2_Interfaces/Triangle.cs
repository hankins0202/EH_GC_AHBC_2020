using System;
using W5D2_Interfaces;

namespace W5D2_Interfaces
{
    public class Triangle : IShape
    {
        //Property not needed they are defined in the Shape Class (Parent class)
        //public double Length { get; set; }
        //public double Height { get; set; }
        public double Side1length { get; set; }
        public double Side2length { get; set; }
        public double Side3length { get; set; }
        public int NumberOfSides { get; set; }

        public Triangle(double side1length, double side2length, double side3length)
        {
            Side1length = side1length;
            Side2length = side2length;
            Side3length = side3length;
            NumberOfSides = 3;
        }


        public double CalculateArea()
        {
            var s = (Side1length + Side2length + Side3length) / 2;         

            var area = Math.Round(Math.Sqrt(s * (s - Side1length) * (s - Side2length) * (s - Side3length)),2);
            return area;
        }
    }
}
