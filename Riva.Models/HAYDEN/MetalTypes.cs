using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class MetalTypes
    {
        public MetalTypes()
        {
            OrderDetailsTry = new HashSet<OrderDetailsTry>();
            OrderDetailsTrytest = new HashSet<OrderDetailsTrytest>();
        }

        public int ColorId { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<OrderDetailsTry> OrderDetailsTry { get; set; }
        public virtual ICollection<OrderDetailsTrytest> OrderDetailsTrytest { get; set; }
    }
}
