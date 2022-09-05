using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmUserGroup
    {
        public long GroupIndex { get; set; }
        public string? GroupName { get; set; }
        public bool? GroupActive { get; set; }
        public string? FarmId { get; set; }
    }
}
