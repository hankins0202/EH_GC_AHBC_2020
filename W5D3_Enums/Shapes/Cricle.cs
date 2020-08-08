using System;
namespace W5D3_Enums
{
    public class Circle : IShape
    {
        public NumberOfSides NumberOfSides { get; set; }

        public Circle(NumberOfSides numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
    }
}
