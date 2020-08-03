using System;
namespace EH_GC_Lab10_CircleObjects
{
    public class Circle
    {
        private double radius;

        public double Radius{ get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }
}
