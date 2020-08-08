using System;
namespace W5D2_Interfaces
{
    public class Shape
    {
        public double Length { get; set; }
        public double Height { get; set; }



        // Conductor is not needed in Shape Class (base class). The subclass has it's own conductor
        //public Shape(double length, double height)
        //{
        //    Length = length;
        //    Height = height;
        //}

        public virtual double CalculateArea()//virtual is another keyword that allows the method to be overridable.
        {
            return Length * Height;
        }
    }
}
