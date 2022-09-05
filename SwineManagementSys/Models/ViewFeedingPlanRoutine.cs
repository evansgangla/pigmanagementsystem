using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class ViewFeedingPlanRoutine
    {
        public string? FrAnimalId { get; set; }
        public string? FrGroup { get; set; }
        public string? FrSubGroup { get; set; }
        public decimal? FrGroupNo { get; set; }
        public DateTime? FrDateBorn { get; set; }
        public DateTime? FrCurDate { get; set; }
        public decimal? FrCurAge { get; set; }
        public decimal? FrCurWeight { get; set; }
        public string? FrCycle { get; set; }
        public decimal? FrDependantsNo { get; set; }
        public decimal? FrExpDailyRation { get; set; }
        public decimal? FrExpDepDailyRation { get; set; }
        public decimal? FrExpTotalRation { get; set; }
        public decimal? FrDailyRation { get; set; }
        public decimal? FrConcPer { get; set; }
        public decimal? FrFodPer { get; set; }
        public decimal? FrCurConcPer { get; set; }
        public decimal? FrCurFodPer { get; set; }
        public decimal? FrConcWeight { get; set; }
        public decimal? FrFodWeight { get; set; }
        public string? FrConcName { get; set; }
        public string? FrFodName { get; set; }
        public bool? FrActive { get; set; }
        public string? FarmId { get; set; }
        public string? FarmName { get; set; }
        public string? FarmCounty { get; set; }
    }
}
