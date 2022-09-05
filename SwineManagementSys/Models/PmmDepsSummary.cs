using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmDepsSummary
    {
        public long FpIndex { get; set; }
        public string? FpAnimalId { get; set; }
        public int? FpCycleNo { get; set; }
        public decimal? FpDepsNo { get; set; }
        public DateTime? FpDateBorn { get; set; }
        public string? FarmId { get; set; }
    }
}
