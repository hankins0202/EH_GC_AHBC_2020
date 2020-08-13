using System;
namespace W6D2_Lab13
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get ; set; }

        public HumanPlayer(string name)
        {
            Name = name;
        }

        public RPS GenerateRPS(RPS userChoice = RPS.paper)
        {
            return userChoice;
        }
    }
}
