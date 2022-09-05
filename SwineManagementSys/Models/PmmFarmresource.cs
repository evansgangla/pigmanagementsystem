using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmFarmresource
    {
        public long FrIndex { get; set; }
        public string? FrName { get; set; }
        public string? FrType { get; set; }
        public decimal? FrQuantity { get; set; }
        public string? FrMetric { get; set; }
        public string? FrSupplier { get; set; }
        public string? FrGrnnumber { get; set; }
        public string? FrComment { get; set; }
        public DateTime? FrDate { get; set; }
        public decimal? FrUnitcost { get; set; }
        public decimal? FrTotalCost { get; set; }
        public bool? FrActive { get; set; }
        public decimal? FrTotalcost1 { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
        public string? Reorder { get; set; }
        public string? StoreId { get; set; }
    }
}
