using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmFeedingPlanPg
    {
        public long PgIndex { get; set; }
        public string? PgExpAct { get; set; }
        public int? PgCycleIndex { get; set; }
        public string? PgSowId { get; set; }
        public DateTime? PgDateBorn { get; set; }
        public DateTime? PgDate { get; set; }
        public int? PgAge { get; set; }
        public DateTime? PgDateFrom { get; set; }
        public DateTime? PgDateTo { get; set; }
        public decimal? PgRation { get; set; }
        public string? PgFarmId { get; set; }
        public bool? PgActive { get; set; }
    }
}
