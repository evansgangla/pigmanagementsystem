using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmReport
    {
        public decimal? ReportOrder { get; set; }
        public string ReportIndex { get; set; } = null!;
        public string? ReportModule { get; set; }
        public string? ReportDisplayName { get; set; }
        public string? ReportName { get; set; }
        public bool? Active { get; set; }
        public long RptIdx { get; set; }
    }
}
