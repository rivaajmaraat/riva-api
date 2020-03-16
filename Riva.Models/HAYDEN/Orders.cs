using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class Orders
    {
        public Orders()
        {
            OrdersDetails = new HashSet<OrdersDetails>();
        }

        public int OrdersId { get; set; }
        public string OrderNoInternal { get; set; }
        public string OrderNoCustomer { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerId { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int OrderStatus { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<OrdersDetails> OrdersDetails { get; set; }
    }
}
