using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmStockUpdateLog
    {
        public long UpdateIndex { get; set; }
        public DateTime? Date { get; set; }
        public string? FarmId { get; set; }
        public string? Source { get; set; }
        public string? UserId { get; set; }
    }
}
