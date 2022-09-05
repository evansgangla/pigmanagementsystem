using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmActivity
    {
        public long ActIndex { get; set; }
        public string? ActName { get; set; }
        public string? ActDescription { get; set; }
        public bool? ActActive { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
