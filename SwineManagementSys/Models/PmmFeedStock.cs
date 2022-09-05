using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmFeedStock
    {
        public long FsIndex { get; set; }
        public string? FsFeedName { get; set; }
        public string? FsFeedType { get; set; }
        public decimal? FsCurrentStock { get; set; }
        public string? FsUnit { get; set; }
        public decimal? FsMinimumStock { get; set; }
        public decimal? FsDeficitStock { get; set; }
        public decimal? FsCostPerKg { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
