using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class GemInventory
    {
        public int GemId { get; set; }
        public string Sku { get; set; }
        public string CustomerSku { get; set; }
        public string Location { get; set; }
        public string GemName { get; set; }
        public string GemColor { get; set; }
        public string SizeMm { get; set; }
        public string Shape { get; set; }
        public string WeightCarat { get; set; }
        public string Type { get; set; }
        public string Owner { get; set; }
        public string LinkedOrder { get; set; }
        public string LinkedOrderItem { get; set; }
        public int CurrentStatus { get; set; }
        public bool Used { get; set; }
        public DateTime DateReceived { get; set; }
        public DateTime? DateUsed { get; set; }
    }
}
