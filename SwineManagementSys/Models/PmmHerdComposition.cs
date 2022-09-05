using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmHerdComposition
    {
        public long HcIndex { get; set; }
        public string? HcAnimalId { get; set; }
        public DateTime? HcDateBorn { get; set; }
        public string? HcSource { get; set; }
        public string? HcBreedType { get; set; }
        public decimal? HcUnitCost { get; set; }
        public decimal? HcGroupBought { get; set; }
        public decimal? HcGroupValue { get; set; }
        public string? HcParentSow { get; set; }
        public string? HcParentBoar { get; set; }
        public decimal? HcAge { get; set; }
        public string? HcAgeUnit { get; set; }
        public string? HcGroup { get; set; }
        public string? HcSubGroup { get; set; }
        public decimal? HcGroupOpeningStock { get; set; }
        public decimal? HcGroupNo { get; set; }
        public string? HcCycle { get; set; }
        public decimal? HcOpenningStock { get; set; }
        public decimal? HcWeight { get; set; }
        public string? HcWeightUnits { get; set; }
        public DateTime? HcDateCreated { get; set; }
        public bool? HcActive { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
        public string? HcFarrowdate { get; set; }
        public string? HcPen { get; set; }
        public string? HcServingdate { get; set; }
        public string? HcWeandate { get; set; }
    }
}
