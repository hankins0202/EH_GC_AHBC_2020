using System;
using W13D3_CalculatorApp.Models;

namespace W13D3_CalculatorApp.Services
{
    public class CalculationService : ICalculationService
    {
        public CalculatorViewModel Calculate(CalculatorViewModel model)
        {
            switch (model.Action)
            {
                case CalculatorTypeEnums.Add:
                    model.Result = (model.InputOne + model.InputTwo).ToString();
                    break;

                case CalculatorTypeEnums.Subtract:
                    model.Result = (model.InputOne - model.InputTwo).ToString();
                    break;

                case CalculatorTypeEnums.Multiply:
                    model.Result = (model.InputOne * model.InputTwo).ToString();
                    break;

                case CalculatorTypeEnums.Divide:
                    model.Result = (model.InputOne / model.InputTwo).ToString();
                    break;
            }
            return model;
        }
    }
}
