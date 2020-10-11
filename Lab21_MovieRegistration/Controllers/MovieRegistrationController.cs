using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21_MovieRegistration.Models;
using Lab21_MovieRegistration.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab21_MovieRegistration.Controllers
{
    public class MovieRegistrationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(MovieRegistrationViewModel model)
        {
            
            return View(model);
        }
    }
}
