using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieWebAppLabs_21222324.DataLayer.Context;
using MovieWebAppLabs_21222324.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieWebAppLabs_21222324.Controllers
{
    public class MovieRegistrationController : Controller
    {

        private readonly ApplicationDBContext _context;

        public MovieRegistrationController(ApplicationDBContext context)
        {
            _context = context;
        }

      
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Result([Bind("Id, Name, Genre, Runtime")]MovieRegistrationViewModel model)
        {
            if(ModelState.IsValid)
            {
                _context.Add(model.Movies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
