using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class ViewCurrentBreedingPlan
    {
        public int? BpCycleIndex { get; set; }
        public string? BpSowId { get; set; }
        public DateTime? BpDateBorn { get; set; }
        public string? BpBoarId { get; set; }
        public string? BpBatchId { get; set; }
        public string? BpGroup { get; set; }
        public string? BpSubGroup { get; set; }
        public DateTime? BpExpServingDt { get; set; }
        public DateTime? BpExpKiddlingDt { get; set; }
        public decimal? BpExpBorn { get; set; }
        public decimal? BpExpPreweanMort { get; set; }
        public decimal? BpExpDeadPre { get; set; }
        public DateTime? BpExpWeaningDt { get; set; }
        public decimal? BpExpWeaned { get; set; }
        public decimal? BpExpPostweanMort { get; set; }
        public decimal? BpExpDeadPost { get; set; }
        public bool? BpStatus { get; set; }
        public string? FarmId { get; set; }
        public string? FarmName { get; set; }
        public string? FarmCounty { get; set; }
    }
}
