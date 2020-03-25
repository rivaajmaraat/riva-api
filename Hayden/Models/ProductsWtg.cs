﻿using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class ProductsWtg
    {
        public int ProductsWtgid { get; set; }
        public int ProductsId { get; set; }
        public bool Finished { get; set; }
        public decimal Wtg { get; set; }

        public virtual Products Products { get; set; }
    }
}
