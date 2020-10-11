using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using W13D3_CalculatorApp.Models;
using W13D3_CalculatorApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace W13D3_CalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculationService _calculationService;

        public CalculatorController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalculateResult(CalculatorViewModel model)
        {
            //var calcService = new CalculationService(); We injected the
            var calculatorViewModel = _calculationService.Calculate(model);

            var viewResultModel = new ResultViewModel
            {
                Result = calculatorViewModel.Result
            };
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
