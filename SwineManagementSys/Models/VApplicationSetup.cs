using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class VApplicationSetup
    {
        public string? FarmName { get; set; }
        public string? SetupCategory { get; set; }
        public string? SetupName { get; set; }
        public string? SetupValue { get; set; }
        public string? SetupDescription { get; set; }
        public string? FarmId { get; set; }
    }
}
