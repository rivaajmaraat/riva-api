using System;
using System.Collections.Generic;

namespace Riva.Models.RivaSQL
{
    public partial class TblInventoryFgLog
    {
        public int ITransId { get; set; }
        public DateTime? DtDate { get; set; }
        public string CUser { get; set; }
        public string CStation { get; set; }
        public string CSource { get; set; }
        public int? IInventoryId { get; set; }
        public string CInventoryNo { get; set; }
        public decimal? ITransAmt { get; set; }
        public decimal? ITransWt { get; set; }
        public string CUom { get; set; }
        public int? ISourceDocId { get; set; }
        public decimal? MtcSilverWtgrm { get; set; }
        public decimal? MtcGoldWtgrm { get; set; }
        public decimal? MtcGoldKt { get; set; }
        public decimal? MtcPtwtgrm { get; set; }
    }
}
