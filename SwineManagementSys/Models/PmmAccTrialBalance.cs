using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmAccTrialBalance
    {
        public long TrialIndex { get; set; }
        public string? Account { get; set; }
        public decimal? DrAmount { get; set; }
        public decimal? CrAmount { get; set; }
        public string? FarmId { get; set; }
    }
}
