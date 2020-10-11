using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Lab21_MovieRegistration.Models
{
    public class MovieRegistrationViewModel
    {
        //Primary Key
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(255,MinimumLength =3)]
        public string Title { get; set; }

        [StringLength(255, MinimumLength = 3)]
        public string Genre { get; set; }

        //add attribute to validate year

        [StringLength(4, MinimumLength = 0)]
        public string Year { get; set; }

        [StringLength(255, MinimumLength = 3)]
        public string Actors { get; set; }

        [StringLength(255, MinimumLength = 3)]
        public string Directors { get; set; }
    }
}
