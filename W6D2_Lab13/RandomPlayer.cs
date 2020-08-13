using System;
namespace W6D2_Lab13
{
    public class RandomPlayer : IPlayer
    {
        public RandomPlayer()
        {
        }

        public string Name { get ; set ; }

        //public RPS GenerateRPS() no things in the parenthesis
        //{

        //}

        public RPS GenerateRPS(RPS userChoice = RPS.paper)
        {
            Random random = new Random();
            //RPS RandomRPS = (RPS)random.Next(3);
            //return RandomRPS
            return (RPS)random.Next(3);
        }
    }
}
