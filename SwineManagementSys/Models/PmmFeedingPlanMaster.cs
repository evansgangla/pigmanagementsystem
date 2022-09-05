using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmFeedingPlanMaster
    {
        public long FpIndex { get; set; }
        public string? FpAnimalId { get; set; }
        public DateTime? FpDateBorn { get; set; }
        public string? FpGroup { get; set; }
        public decimal? FpGroupNo { get; set; }
        public DateTime? FpDateFrom { get; set; }
        public DateTime? FpDateTo { get; set; }
        public string? FpConcName { get; set; }
        public decimal? FpPregnantDays { get; set; }
        public decimal? FpPreganantRation { get; set; }
        public decimal? FpPregnantConcWt { get; set; }
        public decimal? FpPregnantFodWt { get; set; }
        public decimal? FpPregnantConcCost { get; set; }
        public decimal? FpPregnantFodCost { get; set; }
        public decimal? FpPregnantCost { get; set; }
        public decimal? FpDepsNo { get; set; }
        public decimal? FpDepsDays { get; set; }
        public decimal? FpDepsRation { get; set; }
        public decimal? FpDepsConcWt { get; set; }
        public decimal? FpDepsFodWt { get; set; }
        public decimal? FpDepsConcCost { get; set; }
        public decimal? FpDepsFodCost { get; set; }
        public decimal? FpDepsCost { get; set; }
        public decimal? FpNormalDays { get; set; }
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
        public string? FpFarmId { get; set; }
        public string? FpExpAct { get; set; }
        public bool? FpActive { get; set; }
    }
}
