using System;
using System.Collections.Generic;

namespace Riva.Models.Models
{
    public partial class MetalKarats
    {
        public MetalKarats()
        {
            OrderDetailsTry = new HashSet<OrderDetailsTry>();
            OrderDetailsTrytest = new HashSet<OrderDetailsTrytest>();
        }

        public int KaratId { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<OrderDetailsTry> OrderDetailsTry { get; set; }
        public virtual ICollection<OrderDetailsTrytest> OrderDetailsTrytest { get; set; }
    }
}
