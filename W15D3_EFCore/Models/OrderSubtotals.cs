using System;
using System.Collections.Generic;

namespace W15D3_EFCore.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
