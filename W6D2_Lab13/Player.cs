using System;
namespace W6D2_Lab13
{
    public interface IPlayer
    {
        public string Name { get; set; }

        public RPS GenerateRPS(RPS userChoice = RPS.paper);       
    }
}
