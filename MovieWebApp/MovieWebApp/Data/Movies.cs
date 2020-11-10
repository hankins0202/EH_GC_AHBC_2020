using System;
using Microsoft.AspNetCore.Identity;

namespace MovieWebApp.Data
{
    public class Movies
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Runtime { get; set; }
        public string UserCheckedOut { get; set; }
        public bool CheckedOut { get; set; }
        //public IdentityUser identityUser { get; set; }
    }
}
