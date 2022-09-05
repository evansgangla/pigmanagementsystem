using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmCounty
    {
        public long CountyIndex { get; set; }
        public string CountyId { get; set; } = null!;
        public string? CountyName { get; set; }
        public string? SvcStatus { get; set; }
        public bool? Active { get; set; }
    }
}
