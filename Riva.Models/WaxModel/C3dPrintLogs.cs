using System;
using System.Collections.Generic;

namespace Riva.Models.WaxModel
{
    public partial class C3dPrintLogs
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string RequestedBy { get; set; }
        public string NameReference { get; set; }
        public string ItemPath { get; set; }
        public int? Qty { get; set; }
        public string Metal { get; set; }
        public DateTime? WaxReceivedCastingDate { get; set; }
        public DateTime? SampleReceivedManagerDate { get; set; }
    }
}
