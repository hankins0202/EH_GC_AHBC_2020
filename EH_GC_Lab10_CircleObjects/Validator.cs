using System;
namespace EH_GC_Lab10_CircleObjects
{
    public class Validator : Circle
    {
        public Validator(double radius) : base(radius)
        {

        }

        //Arrange
        double AreaExpected = 3.14;
        double CircumferenceExpected = 6.28;

        //Act
        //public double CalculateCircumference()
        //{
   
        //}
        //public string CalculateFormattedCircumference()
        //{
        //    return FormatNumber(CalculateCircumference());
        //}
        //public double CalculateArea()
        //{
        //    return Math.PI * (Radius * Radius);
        //}
        //public string CalculateFormattedArea()
        //{
        //    return FormatNumber(CalculateArea());
        //}
        //private string FormatNumber(double x)
        //{
        //    return Math.Round(x, 2).ToString();
        //}

    }
}
