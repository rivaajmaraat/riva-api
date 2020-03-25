using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class VwJsonFiles
    {
        public int Idx { get; set; }
        public DateTime DateEntry { get; set; }
        public string Jsontext { get; set; }
        public string Sku { get; set; }
        public string CustomerOrderNo { get; set; }
        public string Name { get; set; }
    }
}
