using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmAlertLog
    {
        public long Index { get; set; }
        public string? AlertId { get; set; }
        public string? ModuleId { get; set; }
        public string? ModuleName { get; set; }
        public string? Category { get; set; }
        public string? Message { get; set; }
        public DateTime? AlertDate { get; set; }
        public string? FarmId { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
