using System;
using System.Collections.Generic;

namespace Riva.Models.WaxModel
{
    public partial class WaxLogs
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string RequestedBy { get; set; }
        public string Customer { get; set; }
        public int? QtyUnits { get; set; }
        public string Style { get; set; }
        public string Metal { get; set; }
        public DateTime? UnitsMadeDate { get; set; }
        public string UnitsMadeBy { get; set; }
        public DateTime? UnitsReceivedDate { get; set; }
        public string UnitsReceivedBy { get; set; }
    }
}
