using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmAlertsSetup
    {
        public long AlertSetupIndex { get; set; }
        public long? ModuleId { get; set; }
        public string? ModuleName { get; set; }
        public string? ThresholdFigure { get; set; }
        public string? ThresholdDuration { get; set; }
        public string? FrequencyFigure { get; set; }
        public string? FrequencyDuration { get; set; }
        public string? Message { get; set; }
        public string? Category { get; set; }
        public string? FarmId { get; set; }
        public bool? Active { get; set; }
        public string? SvcStatus { get; set; }
    }
}
