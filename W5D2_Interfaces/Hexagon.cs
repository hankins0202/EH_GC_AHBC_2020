using System;
namespace W5D2_Interfaces
{
    public class RegularHexagon : IShape
    {
        public RegularHexagon(double sideLength)
        {
            NumberOfSides = 6;
        }

        public int NumberOfSides { get; set; }
        private double _sideLength;

        public double SideLength
        {
            get
            {
                return _sideLength;
            }
            set
            {
                if (value > 0)
                {
                    _sideLength = value;
                }
                else
                {
                    throw new Exception("Side length cannot be 0 or less!!");
                }
            }
        }

        public double CalculateArea()
        {
            var area = (3 * Math.Sqrt(3) * Math.Pow(SideLength, 2)) / 2;

            return area;
        }

        public string NumberofSidesAsMessage()
        {
            return $"A {nameof(RegularHexagon)} has {NumberOfSides}"; //nameof new keyword.  Real world zip to postal code
        }
    }
}
