using System;
using System.Collections.Generic;
using System.Linq;

namespace EH_GC_Lab11_MovieDatabase
{
    public class Movie
    {

        private string _title;
        private string _category;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public object MovieList { get; internal set; }

        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }

        public void ReturnCategoryMovieList(MovieType movie, List<Movie> SortedMovieList)
        {
            Console.WriteLine("\n---------------------------------------------\n");
            foreach (var item in SortedMovieList)
            {
                MovieType movieCat = (MovieType)Enum.Parse(typeof(MovieType), item.Category);
                if (movieCat == movie)
                {
                    Console.WriteLine("{0}", item.Title);
                }
            }
            Console.WriteLine("\n---------------------------------------------\n");
        }

        public void AddMovieToList()
        {
            Console.WriteLine("Enter the title of the new movie.");
            string NewMovieTitle = Console.ReadLine();
            Console.WriteLine("Enter the number for the category of the new movie.");
            string NewMovieCategory = Console.ReadLine();
            MovieType movieCat = (MovieType)Enum.Parse(typeof(MovieType), NewMovieCategory); ;//converting string input to enum output
            ListOfMovies NewMovie = new ListOfMovies(NewMovieTitle, movieCat.ToString());

            NewMovie.MovieList.Add(NewMovie);

            Console.WriteLine("Movie has been added");
        }

        public void ReturnEntireList()
        {
            ListOfMovies AllMovies = new ListOfMovies("", "");
            List<Movie> SortAllMovies = AllMovies.MovieList.OrderBy(a => a.Title).ToList();
            foreach (var item in SortAllMovies)
            {
                Console.WriteLine("{0}, {1}", item.Title, item.Category);
            }
        }
    }
}
