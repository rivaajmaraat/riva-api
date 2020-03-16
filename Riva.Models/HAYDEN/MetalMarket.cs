using System;
using System.Collections.Generic;

namespace Riva.Models.HAYDEN
{
    public partial class MetalMarket
    {
        public int MetalMarketId { get; set; }
        public DateTime? MarketDate { get; set; }
        public DateTime? EnteredDate { get; set; }
        public decimal? Silver { get; set; }
        public decimal? Gold { get; set; }
        public decimal? Platinum { get; set; }
        public decimal? Palladium { get; set; }
        public decimal? Rhodium { get; set; }
    }
}
