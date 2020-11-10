using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieWebApp.Data;
using MovieWebApp.Models;

namespace MovieWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _context;
        private readonly IdentityDbContext _IdentityDbContext;


        public HomeController(ILogger<HomeController> logger, ApplicationDBContext context, IdentityDbContext identityDbContext)
        {
            _logger = logger;
            _context = context;
            _IdentityDbContext = identityDbContext;
        }

        //public async Task<IActionResult> IndexAsync()
        //{
        //    var movie = _context.Movies.OrderBy(_ => _.Name).ToListAsync();
        //    return View(await movie);
        //}

        public ViewResult Index(string sortOrder, string searchString, string genreString)
        {
            //ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "";
            //ViewBag.DateSortParm = sortOrder == "Name" ? "Genre" : "Runtime";
            var movie = from m in _context.Movies
                        select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                movie = movie.OrderBy(m=>m.Name).Where(m => m.Name.Contains(searchString));
            }
            else if (!String.IsNullOrEmpty(genreString))
            {
                movie = movie.OrderBy(m => m.Genre).Where(m => m.Genre.Contains(genreString));
            }
            switch (sortOrder)
            {
                case "Name":
                    movie = movie.OrderBy(m => m.Name);
                    break;
                case "Genre":
                    movie = movie.OrderBy(m => m.Genre);
                    break;
            }
            return View(movie.ToList().OrderBy(m=>m.Name));
        }

        public async Task<IActionResult> CheckOut(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckOut(int id, [Bind("ID,Name,Genre,Runtime,UserCheckedOut,CheckedOut")] Data.Movies movie)
        {
            if (id != movie.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(movie.CheckedOut == true)
                    {
                        movie.UserCheckedOut = HttpContext.User.Identity.Name;
                    }
                    else
                    {
                        movie.UserCheckedOut = "";
                    }
                    _context.Update(movie);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
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

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.ID == id);
        }

    }
}
