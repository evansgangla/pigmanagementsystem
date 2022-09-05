using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmHerdBatchId
    {
        public long Idx { get; set; }
        public string? AnimalBatchId { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
