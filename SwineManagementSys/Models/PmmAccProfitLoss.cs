using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmAccProfitLoss
    {
        public long TrialIndex { get; set; }
        public long? AppearanceIndex { get; set; }
        public string? Account { get; set; }
        public decimal? Value { get; set; }
        public string? FarmId { get; set; }
        public string? Category { get; set; }
    }
}
