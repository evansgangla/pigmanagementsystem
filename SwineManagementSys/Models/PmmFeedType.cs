using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmFeedType
    {
        public long FbIndex { get; set; }
        public string? FbName { get; set; }
        public string? FbType { get; set; }
        public decimal? FbWeight { get; set; }
        public string? FbWtUnit { get; set; }
        public decimal? FbCost { get; set; }
        public decimal? FbCostPerKg { get; set; }
        public bool? FbActive { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
