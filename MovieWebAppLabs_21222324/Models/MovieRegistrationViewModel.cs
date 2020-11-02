using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MovieWebAppLabs_21222324.DataLayer.Context;

namespace MovieWebAppLabs_21222324.Models
{
    public class MovieRegistrationViewModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(255, MinimumLength = 3)]
        public string Genre { get; set; }

        //add attribute to validate year

        [StringLength(50, MinimumLength = 0)]
        public string Runtime { get; set; }

        public virtual Movies Movies { get; set; }
    }
}
