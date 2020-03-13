using System;
using System.Collections.Generic;

namespace Riva.Models.RivaSQL
{
    public partial class OrderDetails
    {
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public string ProductNo { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int QtyBo { get; set; }
        public float? Discount { get; set; }
        public int OrderItem { get; set; }
        public string Freeform1 { get; set; }
        public string Freeform2 { get; set; }
        public string Description { get; set; }
        public bool? SalePosted { get; set; }
        public bool? UpdateCustomerPrice { get; set; }
        public double? GoldDwt { get; set; }
        public DateTime? BuyDate { get; set; }
        public short? Karat { get; set; }
        public bool? BuyGold { get; set; }
        public decimal? GramPrice { get; set; }
        public string Sku { get; set; }
        public bool? PostedToWax { get; set; }
        public int? QtyAllocated { get; set; }
        public decimal? MtcSilverWtgrm { get; set; }
        public decimal? MtcGoldWtgrm { get; set; }
        public byte? MtcGoldKt { get; set; }
        public decimal? MtcPtwtgrm { get; set; }
        public decimal? MtcStoneCost { get; set; }
        public int? QtyPacked { get; set; }
        public bool? OrderedRm { get; set; }
        public bool? OrderedCasting { get; set; }
        public bool? OrderedFindings { get; set; }
        public bool? OrderedChain { get; set; }
        public int? RmorderNo { get; set; }
        public int? CastingOrderNo { get; set; }
        public int? FindingsOrderNo { get; set; }
        public string DiamondNo { get; set; }
        public int? StoneReq { get; set; }
        public int? StoneRec { get; set; }
        public DateTime? StoneRecDate { get; set; }
        public int? ForeCastId { get; set; }
        public string So { get; set; }
        public byte? OrderType { get; set; }
        public bool? SpCharges { get; set; }
        public string COrderLineStatus { get; set; }
        public string StoneDesc { get; set; }
        public int StoneQty { get; set; }
        public string Agtacode { get; set; }
        public decimal MktpriceSs { get; set; }
        public decimal MktpriceG { get; set; }
        public decimal MktpricePt { get; set; }
        public decimal MktpricePalladium { get; set; }
        public decimal MktpriceRuthenium { get; set; }
        public DateTime? ReqDateSku { get; set; }
        public decimal HofLabor { get; set; }
        public string Muser { get; set; }
        public DateTime? Mdate { get; set; }
    }
}
