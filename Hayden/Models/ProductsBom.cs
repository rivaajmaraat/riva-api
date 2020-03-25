using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class ProductsBom
    {
        public int ProductsBomid { get; set; }
        public int ProductsId { get; set; }
        public decimal Qty { get; set; }
        public string Description { get; set; }

        public virtual Products Products { get; set; }
    }
}
