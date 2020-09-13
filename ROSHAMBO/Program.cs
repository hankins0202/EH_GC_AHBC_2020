using System;

namespace ROSHAMBO
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to ROSHAMBO");
                Console.WriteLine("First player, choose your weapon of mass destruction. 0. Rock, 1. Paper, or 2. Scissors.");
                RPS input = (RPS)int.Parse(Console.ReadLine());
                Console.WriteLine("Second player, choose your weapon of mass destruction. 0. Rock, 1. Paper, or 2. Scissors.");
                RPS input1 = (RPS)int.Parse(Console.ReadLine());
                InputService inputService = new InputService();
                var result = inputService.Play(input, input1);
                Console.WriteLine($"{result}");
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
