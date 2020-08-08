using System;
namespace W5D2_Interfaces
{
    public class Triangle : Shape
    {
        //Property not needed they are defined in the Shape Class (Parent class)
        //public double Length { get; set; }
        //public double Height { get; set; }


        public Triangle(double side1length, double side2length, double side3length)
        {
            Side1length = side1length;
            Side2length = side2length;
            Side3length = side3length;
        }
        public double Side1length { get; set; }
        public double Side2length { get; set; }
        public double Side3length { get; set; }

        public override double CalculateArea()
        {
            var s = (Side1length + Side2length + Side3length) / 2;         

            var area = (int)Math.Round(Math.Sqrt(s * (s - Side1length) * (s - Side2length) * (s - Side3length)));
            return area;
        }
    }
}
