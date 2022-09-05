using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmBatchMaster
    {
        public long BatchIndex { get; set; }
        public string? BatchId { get; set; }
        public DateTime? BatchingDate { get; set; }
        public string? BatchingGroup { get; set; }
        public decimal? BatchingGroupNo { get; set; }
        public decimal? BatchingWeight { get; set; }
        public DateTime? BatchMinDob { get; set; }
        public DateTime? BatchMaxDob { get; set; }
        public bool? Active { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
