using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class AstCullingReason
    {
        public long CullIndex { get; set; }
        public bool? Select { get; set; }
        public string? FarmId { get; set; }
        public string? CullReason { get; set; }
        public decimal? NoAffected { get; set; }
        public string? SvcStatus { get; set; }
        public bool? Active { get; set; }
    }
}
