using System;
using Lab21_MovieRegistration.Models;

namespace Lab21_MovieRegistration.Services
{
    public class ResultService
    {
        public string Result(MovieRegistrationViewModel model)
        {
            return model.Title;
        }
    }
}
