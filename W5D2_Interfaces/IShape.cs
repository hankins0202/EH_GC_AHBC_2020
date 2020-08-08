using System;
namespace W5D2_Interfaces
{
    public interface IShape
    {
        public int NumberOfSides { get; set; }

        public double CalculateArea();
    }
}
