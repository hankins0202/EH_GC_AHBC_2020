using System;
using System.Collections.Generic;

namespace EH_GC_Lab11_MovieDatabase
{
    public class ListOfMovies : Movie
    {
        public ListOfMovies(string _title, string _category) : base(_title, _category)
        {
        }

        private static List<Movie> movieList = new List<Movie>
        {
            new Movie ("Aladdin",MovieType.Animated.ToString()),
            new Movie ("Beauty and The Beast",MovieType.Animated.ToString()),
            new Movie ("The Little Mermaid",MovieType.Animated.ToString()),
            new Movie ("The Imitation Game",MovieType.Drama.ToString()),
            new Movie ("Jobs",MovieType.Drama.ToString()),
            new Movie ("The Big Short",MovieType.Drama.ToString()),
            new Movie ("Star Wars",MovieType.SciFi.ToString()),
            new Movie ("The Ring",MovieType.Horror.ToString()),
            new Movie ("E.T.",MovieType.SciFi.ToString()),
            new Movie ("The Conjouring",MovieType.Horror.ToString()),
        };

        public new List<Movie> MovieList
        {
            get { return movieList; }
        }
    }
}
