using System;
using System.Collections.Generic;
using System.Linq;

namespace EH_GC_Lab11_MovieDatabase
{
    public class Movie
    {

        //private string _title;
        //private string _category;

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
        public string Title
        {
            get { return Title; }
            set { Title = value; }
        }
        private string Category
        {
            get { return Category; }
            set { Category = value; }
        }
    }
}
