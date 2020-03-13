using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class Status
    {
        public Status()
        {
            MetalKarats = new HashSet<MetalKarats>();
            MetalTypes = new HashSet<MetalTypes>();
            ProductsTry = new HashSet<ProductsTry>();
        }

        public int StatusId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MetalKarats> MetalKarats { get; set; }
        public virtual ICollection<MetalTypes> MetalTypes { get; set; }
        public virtual ICollection<ProductsTry> ProductsTry { get; set; }
    }
}
