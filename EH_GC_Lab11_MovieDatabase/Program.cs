using System;
using System.Collections.Generic;
using System.Linq;

namespace EH_GC_Lab11_MovieDatabase
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the Movie List Application!" +
            $"\n\nThere are 100 movies on the list.");
            bool continueProgram;
            do
            {

                Console.WriteLine($"\n\nWhat category are you interested in?" +
                $"\n\nEnter the number assoiciated with the category." +
                $"\nExample if you want SciFi enter the number 4.\n" +
                $"---------------------------------------------\n");


                //Console.WriteLine($"{MovieType.Animated}........0");
                //Console.WriteLine($"{MovieType.Drama}...........1");
                //Console.WriteLine($"{MovieType.Horror}..........2");
                //Console.WriteLine($"{MovieType.Romance}.........3");
                //Console.WriteLine($"{MovieType.SciFi}...........4");



                List<Movie> MovieList = new List<Movie>() { };
                MovieList.Add(new Movie("Aladdin", MovieType.Animated.ToString()));
                MovieList.Add(new Movie("Beauty and The Best", MovieType.Animated.ToString()));

                foreach (var movie in MovieList)
                {
                    Console.WriteLine("{0}",movie.Title);
                }

             UserContinue continue1 = new UserContinue();
             continueProgram = continue1.DetermineContinueStatus();

            } while (continueProgram);
        }
    }
}
