using System;
using System.Collections.Generic;

namespace W15D3_EFCore.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Hiring { get; set; }
        public string Location { get; set; }
    }
}
