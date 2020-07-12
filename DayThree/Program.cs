using System;

namespace DayThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi! What is your age?");
            //int userInput = Convert.ToInt32(Console.ReadLine());

            //if (userInput >= 16) 
            //{
            //    Console.WriteLine("You are old enough to drive. Yay!");
            //}
            //else 
            //{
            //    Console.WriteLine("You are not old enough to drive. In the state of Michigan the age to get your driver's license is 16. :(");
            //}

            //var oldisEnough = number >= 21 ? $"You are old enough {userName}" : $"You are not old enough {userName}";

            //Console.WriteLine(oldisEnough);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Here is the value of i = {i}");
            //}
            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            string YesNo = "";
            string message = "";

            for (int i = userInput; i > 0; i--)
            {
                message = i;
            }
            Console.WriteLine("Would you like to continue (y/n)");
        }
    }
}
