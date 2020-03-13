using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class Types
    {
        public Types()
        {
            OrderDetailsTry = new HashSet<OrderDetailsTry>();
            OrderDetailsTrytest = new HashSet<OrderDetailsTrytest>();
        }

        public int TypeId { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }

        public virtual ICollection<OrderDetailsTry> OrderDetailsTry { get; set; }
        public virtual ICollection<OrderDetailsTrytest> OrderDetailsTrytest { get; set; }
    }
}
