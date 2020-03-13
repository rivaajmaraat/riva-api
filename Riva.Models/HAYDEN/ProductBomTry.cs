using System;
using System.Collections.Generic;

namespace Riva.Models.Models
{
    public partial class ProductBomTry
    {
        public int BomIdx { get; set; }
        public string ProductSku { get; set; }
        public string ComponentName { get; set; }
        public int Qty { get; set; }
    }
}
