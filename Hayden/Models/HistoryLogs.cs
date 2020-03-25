using System;
using System.Collections.Generic;

namespace Hayden.Models
{
    public partial class HistoryLogs
    {
        public int LogIdx { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public string Table { get; set; }
        public int TableIdx { get; set; }
        public string Field { get; set; }
        public string OldFieldValue { get; set; }
        public string NewFieldValue { get; set; }
    }
}
