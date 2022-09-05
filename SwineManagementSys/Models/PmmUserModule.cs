using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmUserModule
    {
        public long ModuleIndex { get; set; }
        public string? ModuleName { get; set; }
        public bool? View { get; set; }
        public bool? Add { get; set; }
        public bool? Edit { get; set; }
        public bool? Delete { get; set; }
        public string? FarmId { get; set; }
        public int ModuleId { get; set; }
    }
}
