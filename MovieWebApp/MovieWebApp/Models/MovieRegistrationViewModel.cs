using System;
namespace MovieWebApp.Models
{
    public class MovieRegistrationViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Runtime { get; set; }
        public bool CheckedOut { get; set; }
    }
}
