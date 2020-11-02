using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieWebAppLabs_21222324.DataLayer.Context;
using MovieWebAppLabs_21222324.Models;

namespace MovieWebAppLabs_21222324.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _applicationDBContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext applicationDBContext)
        {
            _logger = logger;
            _applicationDBContext = applicationDBContext;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var movie = _applicationDBContext.Movies.OrderBy(_ => _.Name).ToListAsync();
            return View(await movie);
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
