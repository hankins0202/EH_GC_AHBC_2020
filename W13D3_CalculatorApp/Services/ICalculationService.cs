using System;
using W13D3_CalculatorApp.Models;

namespace W13D3_CalculatorApp.Services
{
    public interface ICalculationService
    {
        CalculatorViewModel Calculate(CalculatorViewModel model);
    }
}
