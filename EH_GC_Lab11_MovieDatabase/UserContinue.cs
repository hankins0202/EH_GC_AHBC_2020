using System;
namespace EH_GC_Lab11_MovieDatabase
{
    public class UserContinue
    {
        public string userContinue { get; set; }

        public bool DetermineContinueStatus()
        {
            Console.WriteLine("Continue? (y/n):");
            userContinue = Console.ReadLine();

            while (true)
            {
                if (userContinue == "y")
                {
                    Console.WriteLine();
                    return true;
                }
                else if (userContinue == "n") return false;
                else
                {
                    Console.WriteLine("Invalid entry. Please select y to continue the program or n to quit:");
                    userContinue = Console.ReadLine();
                }
            }
        }
    }
}
