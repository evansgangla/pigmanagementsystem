using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmHerdWeight
    {
        public long HwIndex { get; set; }
        public DateTime? HwDate { get; set; }
        public string? HwAnimalId { get; set; }
        public string? HwGroup { get; set; }
        public string? HwSubGroup { get; set; }
        public decimal? HwGroupNo { get; set; }
        public decimal? HwWeight { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
