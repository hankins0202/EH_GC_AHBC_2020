using System;
using W5D2_Interfaces;

namespace W5D2_Interfaces
{
    public class Circle : IShape
    {

            private double _radius;//Best practice is to give an underscore when property is private.  This is the naming convention among devs.

            public double Radius
            {
                get
                {
                return _radius;
                }
                set
                {
                  if(value > 0)//value kw is special (clr) knows an assignment of property.  Value is taking the radius and setting the value of radius.
                    {
                        _radius = value;
                    }
                  else
                    {
                    throw new Exception("Circles cannot have a radius of zero or less.");
                    }
                }
            }

        public int NumberOfSides { get; set; }

        public Circle(double radius)
            {
                Radius = radius;
                NumberOfSides = 0;
            }

            public double CalculateArea()
            {
                return Math.Round(Math.PI * (Radius * Radius),2);
            }

            //public double CalculateCircumference()
            //{
            //    return 2 * Math.PI * Radius;
            //}
            //public string CalculateFormattedCircumference()
            //{
            //    return FormatNumber(CalculateCircumference());
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
