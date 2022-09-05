using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmActivitiesLog
    {
        public long ActIndex { get; set; }
        public DateTime? ActDate { get; set; }
        public string? ActReference { get; set; }
        public string? ActName { get; set; }
        public string? ActDescription { get; set; }
        public string? ActType { get; set; }
        public decimal? ActQuantity { get; set; }
        public string? GlUnit { get; set; }
        public decimal? ActCostPerUnit { get; set; }
        public decimal? ActValue { get; set; }
        public bool? Active { get; set; }
        public string? FarmId { get; set; }
    }
}
