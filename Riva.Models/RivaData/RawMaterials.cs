using System;
using System.Collections.Generic;

namespace Riva.Models.RivaData
{
    public partial class RawMaterials
    {
        public int SaId { get; set; }
        public string PartNo { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public int VendorId { get; set; }
        public int? OutSideVendorId { get; set; }
        public string VendorItemNo { get; set; }
        public string VendorComments { get; set; }
        public decimal? Labor { get; set; }
        public decimal? Cost { get; set; }
        public decimal? RmunitPrice { get; set; }
        public double? QtyInStock { get; set; }
        public double? QtyOnOrder { get; set; }
        public double? QtyReqd { get; set; }
        public bool? JewelrySa { get; set; }
        public bool? Casting { get; set; }
        public bool? ToolDie { get; set; }
        public bool? Shots { get; set; }
        public bool? PureMetal { get; set; }
        public bool? Findings { get; set; }
        public string Pocategory { get; set; }
        public decimal? MaterialCost { get; set; }
        public string Location { get; set; }
        public double? GA { get; set; }
        public int? Karat { get; set; }
        public double? GoldWeight { get; set; }
        public string Size { get; set; }
        public int? Adjusted { get; set; }
        public int? Used { get; set; }
        public int? LastYearAdjusted { get; set; }
        public int? LastYearUsed { get; set; }
        public int? MoldNo { get; set; }
        public float? NoOfMolds { get; set; }
        public string MaterialType { get; set; }
        public string MoldType { get; set; }
        public string TreeType { get; set; }
        public float? TreeQty { get; set; }
        public bool? Dewax { get; set; }
        public int? OvenTemp { get; set; }
        public int? CastingTemp { get; set; }
        public string Commentwax { get; set; }
        public bool? Moldavailable { get; set; }
        public bool? Sampleavailable { get; set; }
        public DateTime? TimeRequired { get; set; }
        public string UnitOfMes { get; set; }
        public string Pum { get; set; }
        public string Sacategory { get; set; }
        public double? MaterialTemp { get; set; }
        public double? MaterialPressure { get; set; }
        public double? ClampPressure { get; set; }
        public DateTime? ShootingTime { get; set; }
        public double? MatelWeight { get; set; }
        public string MetalId { get; set; }
        public string ImageLocation { get; set; }
        public string Category { get; set; }
        public string WeightUom { get; set; }
        public string Customer { get; set; }
        public string Routing { get; set; }
        public string Comments1Rt { get; set; }
        public bool? MtcinvInvalid { get; set; }
        public bool? MtcinvInventory { get; set; }
        public bool? MtcinvTrans { get; set; }
        public bool? InhouseCast { get; set; }
        public bool InActive { get; set; }
        public bool? InspectRange { get; set; }
        public bool? Inspected { get; set; }
        public bool? InspectedBom { get; set; }
        public string BombyUser { get; set; }
        public string PartNoOld { get; set; }
        public string QualityGuidelines { get; set; }
        public bool? Qaapproved { get; set; }
        public bool? Pdapproved { get; set; }
        public string Rmcellno { get; set; }
        public string RmpriceType { get; set; }
        public string RmmetalColor { get; set; }
        public bool? TakesFindings { get; set; }
        public bool? TakesCastings { get; set; }
        public bool? TakesRm { get; set; }
        public decimal? MtcSilverWtgrm { get; set; }
        public decimal? MtcGoldWtgrm { get; set; }
        public short? MtcGoldKt { get; set; }
        public decimal? MtcPtwtgrm { get; set; }
        public decimal? MtcPldwtgrm { get; set; }
        public decimal? MtcStnwtgrm { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
