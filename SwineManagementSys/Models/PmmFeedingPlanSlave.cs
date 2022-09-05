using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmFeedingPlanSlave
    {
        public long FpIndex { get; set; }
        public string? FpAnimalId { get; set; }
        public DateTime? FpDateBorn { get; set; }
        public string? FpGroup { get; set; }
        public decimal? FpGroupNo { get; set; }
        public DateTime? FpDate { get; set; }
        public decimal? FpAge { get; set; }
        public int? FpWeekFrom { get; set; }
        public int? FpWeekTo { get; set; }
        public DateTime? FpDateFrom { get; set; }
        public DateTime? FpDateTo { get; set; }
        public string? FpConcName { get; set; }
        public string? FpFodName { get; set; }
        public decimal? FpConcPer { get; set; }
        public decimal? FpFodPer { get; set; }
        public decimal? FpConcCost { get; set; }
        public decimal? FpFodCost { get; set; }
        public int? FpCycleNo { get; set; }
        public DateTime? FpPregnantDateFrom { get; set; }
        public DateTime? FpPregnantDateTo { get; set; }
        public decimal? FpPregnantRation { get; set; }
        public decimal? FpPregnantConcWt { get; set; }
        public decimal? FpPregnantFodWt { get; set; }
        public decimal? FpPregnantConcCost { get; set; }
        public decimal? FpPregnanctFodCost { get; set; }
        public decimal? FpPregnantCost { get; set; }
        public string? FpPregnantExpAct { get; set; }
        public DateTime? FpDepsDateFrom { get; set; }
        public DateTime? FpDepsDateTo { get; set; }
        public int? FpDepsNo { get; set; }
        public decimal? FpDepsRation { get; set; }
        public decimal? FpDepsConcWt { get; set; }
        public decimal? FpDepsFodWt { get; set; }
        public decimal? FpDepsConcCost { get; set; }
        public decimal? FpDepsFodCost { get; set; }
        public decimal? FpDepsCost { get; set; }
        public string? FpDepsExpAct { get; set; }
        public DateTime? FpNormalDateFrom { get; set; }
        public DateTime? FpNormalDateTo { get; set; }
        public decimal? FpNormalRation { get; set; }
        public decimal? FpNormalConcWt { get; set; }
        public decimal? FpNormalFodWt { get; set; }
        public decimal? FpNormalConcCost { get; set; }
        public decimal? FpNormalFodCost { get; set; }
        public decimal? FpNormalCost { get; set; }
        public decimal? FpTotalRation { get; set; }
        public decimal? FpTotalConcWt { get; set; }
        public decimal? FpTotalFodWt { get; set; }
        public decimal? FpTotalConcCost { get; set; }
        public decimal? FpTotalFodCost { get; set; }
        public decimal? FpTotalCost { get; set; }
        public string? FpExpAct { get; set; }
        public string? FpFarmId { get; set; }
        public bool? FpActive { get; set; }
    }
}
