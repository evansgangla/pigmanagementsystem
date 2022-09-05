using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class AstAccPayMode
    {
        public long PayModeIndex { get; set; }
        public string? ModeId { get; set; }
        public bool? Active { get; set; }
    }
}
