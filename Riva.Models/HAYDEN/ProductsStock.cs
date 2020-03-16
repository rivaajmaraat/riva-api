using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class ProductsStock
    {
        public int ProductsStockId { get; set; }
        public int ProductsId { get; set; }
        public decimal? Size { get; set; }
        public int MaterialCode { get; set; }
        public int Uom { get; set; }
        public decimal Qty { get; set; }

        public virtual Products Products { get; set; }
    }
}
