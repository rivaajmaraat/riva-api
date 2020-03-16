using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class OrdersDetails
    {
        public OrdersDetails()
        {
            OrdersDetailsRgw = new HashSet<OrdersDetailsRgw>();
        }

        public int OrdersDetailsId { get; set; }
        public int OrdersId { get; set; }
        public int ProductsId { get; set; }
        public int MaterialCode { get; set; }
        public decimal? Size { get; set; }
        public int Qtyrequested { get; set; }
        public int Qtyshipped { get; set; }
        public string Comment { get; set; }

        public virtual Orders Orders { get; set; }
        public virtual ICollection<OrdersDetailsRgw> OrdersDetailsRgw { get; set; }
    }
}
