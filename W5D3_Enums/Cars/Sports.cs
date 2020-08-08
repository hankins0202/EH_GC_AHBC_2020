using System;
using W5D3_Enums.Enums;

namespace W5D3_Enums.Cars
{
    public class Sports : IAutomobile
    {
        public int Mileage { get; set; }
        public CarType Type { get; set; }

        public void VroomVroom()
        {
            Console.WriteLine("I go vroom vroom fast!");
        }
    }
}
