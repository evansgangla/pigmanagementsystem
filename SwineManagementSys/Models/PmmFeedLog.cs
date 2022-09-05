using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmFeedLog
    {
        public long StIndex { get; set; }
        public string? StReferenceNo { get; set; }
        public DateTime? StDate { get; set; }
        public string? StFeedName { get; set; }
        public string? StFeedType { get; set; }
        public decimal? StQuantity { get; set; }
        public string? StUnit { get; set; }
        public decimal? StCostPerKg { get; set; }
        public string? StTranSource { get; set; }
        public string? StReason { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
