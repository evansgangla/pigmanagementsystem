using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmBusinessDate
    {
        public long DateIndex { get; set; }
        public DateTime? PrevBusinessDate { get; set; }
        public DateTime? CurBusinessDate { get; set; }
        public DateTime? BusinessDateSysDate { get; set; }
        public bool? Active { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
