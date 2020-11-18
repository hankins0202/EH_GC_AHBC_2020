using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockAssessment7.Models;

namespace MockAssessment7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://grandcircusco.github.io/demo-apis/donuts")
            };

            _httpClient = httpClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Get: Products/3.json
        public IActionResult Search(int id)
        {

            var response = _httpClient.GetAsync($"/demo-apis/donuts/{id}.json").GetAwaiter().GetResult();
            var donutjson = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var donut = JsonSerializer.Deserialize<Donut>(donutjson, options);
            donut.PhotoURL = $"https://grandcircusco.github.io/demo-apis/donuts/images/d{id}.jpg";
            return View(donut);
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
