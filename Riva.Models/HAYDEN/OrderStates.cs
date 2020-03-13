using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class OrderStates
    {
        public OrderStates()
        {
            OrderDetailsTry = new HashSet<OrderDetailsTry>();
            OrderDetailsTrytest = new HashSet<OrderDetailsTrytest>();
            OrdersTestTry = new HashSet<OrdersTestTry>();
            OrdersTry = new HashSet<OrdersTry>();
        }

        public int OrderStateId { get; set; }
        public string StateDescription { get; set; }
        public int StatusId { get; set; }

        public virtual ICollection<OrderDetailsTry> OrderDetailsTry { get; set; }
        public virtual ICollection<OrderDetailsTrytest> OrderDetailsTrytest { get; set; }
        public virtual ICollection<OrdersTestTry> OrdersTestTry { get; set; }
        public virtual ICollection<OrdersTry> OrdersTry { get; set; }
    }
}
