using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using W13D3_CalculatorApp.Models;
using W13D3_CalculatorApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace W13D3_CalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculationService _calculationService;
        private readonly IHttpContextAccessor _httpContext;

        public CalculatorController(ICalculationService calculationService, IHttpContextAccessor httpContext)
        {
            _calculationService = calculationService;
            _httpContext = httpContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
            _httpContext.HttpContext.Session.GetString("lastRequest");
            var lastRequest = _httpContext.HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "lastRequest").Value;
        }

        public IActionResult CalculateResult(CalculatorViewModel request)
        {
            //var calcService = new CalculationService(); We injected the
            var calculatorViewModel = _calculationService.Calculate(model);

            var viewResultModel = new ResultViewModel
            {
                Result = calculatorViewModel.Result
            };

            // Loosely Typed  View Data
            ViewData["StartTime"] = DateTime.Now;

            // Strongly Typed Model
            var model = _calculationService.Calculate(request);

            // Loosely Typed View Bag
            ViewBag.EndTime = DateTime.Now;

            // Loosely Typed Temp Data (Read Once)
            var lastRequest = $"The last request was to {request.Type} {request.FirstNumber} and {request.SecondNumber}";
            TempData["LastRequest"] = lastRequest;

            // Setting in the session to be reused
            _httpContext.HttpContext.Session.SetString("lastRequest", lastRequest);

            // Setting in the cookie (always in the response)
            _httpContext.HttpContext.Response.Cookies.Append("lastRequest", lastRequest);
            //var result = calcService.Calculate(model);
            //do some work of validating the user input
            //do some work of actually calculating

            //Display the results of all the above work somehow??
            //display it in the current page?
            //Display it in the another page?
            //Do we need another model?
            //do we need another view?
            return View(viewResultModel);
        }
    }
}
