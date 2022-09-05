using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmFeedingPlanPd
    {
        public long PdIndex { get; set; }
        public int? PdCycleIndex { get; set; }
        public string? PdExpAct { get; set; }
        public string? PdSowId { get; set; }
        public DateTime? PdDateBorn { get; set; }
        public DateTime? PdDate { get; set; }
        public int? PdAge { get; set; }
        public DateTime? PdDateFrom { get; set; }
        public DateTime? PdDateTo { get; set; }
        public int? PdDeps { get; set; }
        public decimal? PdDepRation { get; set; }
        public decimal? PdDepsTotalRation { get; set; }
        public string? PdFarmId { get; set; }
        public bool? PdActive { get; set; }
    }
}
