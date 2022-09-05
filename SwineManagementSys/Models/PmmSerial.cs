using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmSerial
    {
        public long SerialIndex { get; set; }
        public string? SerialName { get; set; }
        public decimal? SerialNo { get; set; }
        public string? FarmId { get; set; }
    }
}
