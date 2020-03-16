using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class OrdersDetailsRgw
    {
        public int OrdersDetailsRgwid { get; set; }
        public int OrderDetailsId { get; set; }
        public int? OrderCode { get; set; }
        public string MoldCode { get; set; }
        public string RivaCode { get; set; }
        public bool ResizeWax { get; set; }

        public virtual OrdersDetails OrderDetails { get; set; }
    }
}
