using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorTrainingCGI2.models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
