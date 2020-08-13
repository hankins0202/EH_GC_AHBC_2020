using System;
namespace W6D2_Lab13
{
    public class RPSApp
    {
        //HumanPlayer humanPlayer = new HumanPlayer();
        public HumanPlayer HumanPlayer;

     

        public void CreateHumanPlayer(string name)
        {
            HumanPlayer = new HumanPlayer(name);
            //humanPlayer.Name = name;
            //return humanPlayer;
        }

        public IPlayer Opponent;//using interface that was inherited from IPlayer Interface.

        public IPlayer CreateOpponent(int opponentChoice)
        {
            if (opponentChoice == 1)
            {
                Opponent = new RockPlayer();
            }
            else
            {
                Opponent = new RandomPlayer();
                Opponent.Name = "George";
            }

            return Opponent;
 
        }
    }
}
