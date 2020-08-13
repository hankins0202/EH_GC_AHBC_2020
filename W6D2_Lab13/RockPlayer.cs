using System;
namespace W6D2_Lab13
{
    public class RockPlayer : IPlayer
    {
        public string Name { get; set; }

        //public RPS GenerateRPS()
        //{
            
        //}

        public RPS GenerateRPS(RPS userChoice = RPS.paper)
        {
            return RPS.rock;
        }

        public RockPlayer()
        {
            Name  = "Dwayne Johnson";
        }

        //rockplayer = new RockPlayer()
    }
}
