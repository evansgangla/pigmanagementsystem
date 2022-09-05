using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmHerdValuation
    {
        public long HvIndex { get; set; }
        public string? HvGroup { get; set; }
        public decimal? HvDressingPer { get; set; }
        public decimal? HvLiveCostPerKg { get; set; }
        public decimal? HvDressedCostPerKg { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
