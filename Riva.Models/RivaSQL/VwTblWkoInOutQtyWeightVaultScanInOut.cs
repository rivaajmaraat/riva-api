using System;
using System.Collections.Generic;

namespace Riva.Models.RivaSQL
{
    public partial class VwTblWkoInOutQtyWeightVaultScanInOut
    {
        public int Wko { get; set; }
        public string ProductStyle { get; set; }
        public double? Wtgrm { get; set; }
        public int? Qty { get; set; }
    }
}
