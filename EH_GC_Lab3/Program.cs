using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, what is your name?");
            string username = Console.ReadLine();

            bool userContinue = true;
            do
            {
                Console.WriteLine($"{username}, enter an integer between 1 and 100");
                string userInput = (Console.ReadLine());

                int userInteger = -1;
                if (!int.TryParse(userInput, out userInteger))
                {
                    Console.WriteLine("Not a valid entry.");

                }


                if ((userInteger >= 1) && (userInteger <= 100))//doesn't allow for string entry
                {
                    if (userInteger >= 60 && (userInteger % 2) != 0)
                    {
                        Console.WriteLine($"{username}, {userInteger} is odd");
                    }
                    else if ((userInteger % 2) != 0)
                    {
                        Console.WriteLine($"{username}, {userInteger} is odd");
                    }
                    else if ((userInteger % 2) == 0 && userInteger >= 26)
                    {
                        Console.WriteLine($"{username}, {userInteger} is even");
                    }
                    else if ((userInteger % 2) == 0 && userInteger < 26)
                    {
                        Console.WriteLine($"{username}, {userInteger}is less than 25 and even");
                    }
                    else
                    {
                        Console.WriteLine("Invalid integer entry. Enter a whole number between 1 and 100. Press y to continue.");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid integer entry. Enter a whole number between 1 and 100. Press y to continue.");
                }


                //Ask user if they would like to continue
                Console.WriteLine($"{username}, would you like to continue (y/n)?"); //try using method to call method and make a new choice
                var contInput = Console.ReadLine().ToLower();


                if ((contInput == "y") || (contInput == "yes"))
                {

                    userContinue = true;
                }
                else if ((contInput == "n") || (contInput == "no"))
                {
                    userContinue = false;
                    Console.WriteLine($"Thank you, {username}. Goodbye");
                    return;
                }
                else //doesn't ask to continue
                {
                    Console.WriteLine($"{username}, invalid Entry. Press y to continue.");
                }



            } while (userContinue);
        }

        /*public static int EvenOdd(int userInteger)
        {

            
            while ((userInteger >= 1) && (userInteger <= 100))
            {
                int evenOdd = userInteger % 2;
                
            }
            return evenOdd;
         }*/

    }
}

