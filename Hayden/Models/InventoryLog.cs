using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class InventoryLog
    {
        public int Id { get; set; }
        public int BarcodeId { get; set; }
        public string ItemType { get; set; }
        public string ItemNo { get; set; }
        public string Karat { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal? QtyOld { get; set; }
        public decimal QtyNew { get; set; }
        public decimal? GramWgtOld { get; set; }
        public decimal GramWgtNew { get; set; }
        public string WebUser { get; set; }
    }
}
