using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmTrialBalance
    {
        public long TbalIndex { get; set; }
        public string? TbalDetails { get; set; }
        public string? TbalSource { get; set; }
        public string? TbalDrCr { get; set; }
        public decimal? TbalAmount { get; set; }
        public bool? Active { get; set; }
    }
}
