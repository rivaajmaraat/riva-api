using System;
using System.Collections.Generic;

namespace Riva.Models.Models
{
    public partial class OrderDetailsTrytest
    {
        public int OrderIdx { get; set; }
        public string CustomerOrderNo { get; set; }
        public string ItemSku { get; set; }
        public int TypeId { get; set; }
        public int KaratId { get; set; }
        public int KaratId2nd { get; set; }
        public int ColorId { get; set; }
        public int ColorId2nd { get; set; }
        public decimal Size { get; set; }
        public string Customizeable { get; set; }
        public string GemType { get; set; }
        public int OrderStateId { get; set; }
        public int GemQty { get; set; }
        public string Jeweler { get; set; }
        public string Comments { get; set; }

        public virtual MetalTypes Color { get; set; }
        public virtual MetalKarats Karat { get; set; }
        public virtual OrderStates OrderState { get; set; }
        public virtual Types Type { get; set; }
    }
}
