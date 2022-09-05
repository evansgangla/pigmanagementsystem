using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmAlertCategory
    {
        public long Index { get; set; }
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public bool? Active { get; set; }
    }
}
