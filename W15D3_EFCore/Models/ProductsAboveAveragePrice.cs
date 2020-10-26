using System;
using System.Collections.Generic;

namespace W15D3_EFCore.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
