using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MovieWebAppLabs_21222324.DataLayer.Context;

namespace MovieWebAppLabs_21222324.Models
{
    public class MovieRegistrationViewModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Runtime { get; set; }
        public bool CheckedOut { get; set; }
    }
}
