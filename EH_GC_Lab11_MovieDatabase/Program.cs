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
                Console.WriteLine($"{MovieType.Animated}........0\n" +
                $"{MovieType.Drama}...........1\n"+
                $"{MovieType.Horror}..........2\n"+
                $"{MovieType.Romance}.........3\n"+
                $"{MovieType.SciFi}...........4\n"+
                $"Add New Movie...N\n\n");

                try
                {
                    string userCatSelection = Console.ReadLine();//user category selection
                    Movie movie = new Movie("", "");

                    if (userCatSelection.ToLower().Equals("n"))//add new movie to list
                    {
                        movie.AddMovieToList();
                    }
                    else if (userCatSelection.ToLower().Equals("a"))
                    {
                       movie.ReturnEntireList();
                    }
                    MovieType movieType = (MovieType)Enum.Parse(typeof(MovieType), userCatSelection);//converting string input to enum output
                    ListOfMovies listOfMovies = new ListOfMovies(movieType.ToString(), userCatSelection);//instatiating ListOfMovies object
                    List<Movie> SortedMovieList = listOfMovies.MovieList.OrderBy(m => m.Title).ToList();//Sorting the list of movies
                    //Movie MovieCatList = new Movie(movieType.ToString(), SortedMovieList.ToString());//Instiating Movie object.  Code not needed Object movie instantiated on line 31.
                    movie.ReturnCategoryMovieList(movieType, SortedMovieList);//calling method to sort movies
                }
                catch
                {
                    Console.WriteLine("Invalid entry. Choose y to continue.");
                }


                UserContinue continue1 = new UserContinue();
                continueProgram = continue1.DetermineContinueStatus();

            } while (continueProgram);
        }
    }
}
