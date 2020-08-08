using System;
using W5D3_Enums.Enums;

namespace W5D3_Enums.Cars
{
    public class Rickshaw : IAutomobile
    {
        int IAutomobile.Mileage { get; set; }
        CarType IAutomobile.Type { get; set; }

        void IAutomobile.VroomVroom()
        {
            Console.WriteLine("I go roar roar loudly");
        }
    }
}
