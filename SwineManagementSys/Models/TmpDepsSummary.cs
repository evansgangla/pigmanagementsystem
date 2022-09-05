using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class TmpDepsSummary
    {
        public long FpIndex { get; set; }
        public string? FpAnimalId { get; set; }
        public int? FpCycleNo { get; set; }
        public int? FpDepsNo { get; set; }
        public string? FarmId { get; set; }
    }
}
