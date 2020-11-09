using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieWebAppLabs_21222324.Areas.Identity.Data;
using MovieWebAppLabs_21222324.DataLayer.Context;
using MovieWebAppLabs_21222324.Models;

namespace MovieWebAppLabs_21222324.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _context;
        private readonly MovieWebAppLabs_21222324IdentityDbContext _movieWebAppLabs_21222324IdentityDbContext;


        public HomeController(ILogger<HomeController> logger, ApplicationDBContext applicationDBContext, MovieWebAppLabs_21222324IdentityDbContext _context)
        {
            _logger = logger;
            this._context = applicationDBContext;
            _movieWebAppLabs_21222324IdentityDbContext = _context;
        }
        [HttpGet]
        public async Task<IActionResult> MovieSearch(string movieName)
        {
            var movieSearch = await _context.Movies.FindAsync(movieName);

            //if (ModelState.IsValid & movieSearch.Name == movieName)
            //{
            //    var movieSearch = await _context.Movies.FindAsync(movieName);
            //}

           return View(movieSearch);
        }

        public async Task<IActionResult> IndexAsync()
        {
            var movie = _context.Movies.OrderBy(_ => _.Name).ToListAsync();
            return View(await movie);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckOut(int id,[Bind("ID,Nmae,Genre,Runtime")] Movies movie)
        {
            if(id != movie.ID)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                _context.Update(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
