using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace W13D3_CalculatorApp.Models
{
    public class CalculatorViewModel
    {
        public decimal InputOne { get; set; }//What happens when user types $12.12.  Many different ways to handle this scenario
        public decimal InputTwo { get; set; }
        public CalculatorTypeEnums Action { get; set; }
        public string Result { get; set; }
    }
}
