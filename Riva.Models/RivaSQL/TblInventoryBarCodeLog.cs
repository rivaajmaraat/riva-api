using System;
using System.Collections.Generic;

namespace Riva.Models.RivaSQL
{
    public partial class TblInventoryBarCodeLog
    {
        public int Id { get; set; }
        public int? Serial { get; set; }
        public string Item { get; set; }
        public int? Type { get; set; }
        public DateTime? DateTime { get; set; }
        public int? LastCount { get; set; }
        public string Iuom { get; set; }
        public string Karat { get; set; }
        public string UserMachine { get; set; }
        public decimal? GramsPerUnit { get; set; }
        public bool? WtFlg { get; set; }
    }
}
