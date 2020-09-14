using System;

namespace ROSHAMBO
{
    class Program
    {
        static void Main(string[] args)
        {
            InputService inputService = new InputService();
            Console.WriteLine("Welcome to ROSHAMBO");
            do
            {
                bool proceed;
                
                do
                {
                    Console.WriteLine("Player 1 choose your weapon. 0. Rock, 1. Paper, or 2. Scissors");
                    string input = Console.ReadLine();
                    if(inputService.ValidateUserInput(input))
                    {
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Player 2 choose your weapon. 0. Rock, 1. Paper, or 2. Scissors");
                            string input1 = Console.ReadLine();
                            if (inputService.ValidateUserInput(input1))
                            {
                                RPS play = inputService.Play((RPS)int.Parse(input), (RPS)int.Parse(input1));
                                var result = play == RPS.Tie ? "Tie game!" : $"{play} wins!";
                                var playerWin = int.Parse(input) == (int)play ? " Player 1 wins!" : " Player 2 wins!";
                                if(play == RPS.Tie)
                                {
                                    Console.WriteLine(result);
                                }
                                else
                                {
                                    Console.WriteLine($"{result}{playerWin}");
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Entry.");
                                proceed = false;
                                continue;
                            }

                        } while (proceed == false);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry.");
                        proceed = false;
                        continue;
                    }
                } while (proceed == false);

                Console.WriteLine("Play again? Y for yes or N to quit.");

            } while (UserContinue());
        }
        public static bool UserContinue()
        {
            while (true)
            {
                var input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    Console.Clear();
                    return true;
                }
                else if (input == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("You did not enter  'Y' or 'N' ");
                }
            }
        }
    }
}
