using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class ProductsPrices
    {
        public int ProductsWhslid { get; set; }
        public int ProductsId { get; set; }
        public bool? WholeSale { get; set; }
        public int? MaterialCode { get; set; }
        public decimal? Size { get; set; }
        public decimal? Price { get; set; }

        public virtual Products Products { get; set; }
    }
}
