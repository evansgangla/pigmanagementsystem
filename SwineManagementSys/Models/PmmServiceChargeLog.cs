using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmServiceChargeLog
    {
        public long ChargeLogIndex { get; set; }
        public string? ChargeLogId { get; set; }
        public DateTime? ChargeDate { get; set; }
        public decimal? RangeFrom { get; set; }
        public decimal? RangeTo { get; set; }
        public decimal? RangeAmount { get; set; }
        public decimal? NoOfAnimals { get; set; }
        public decimal? UnitAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? FarmId { get; set; }
        public string? PayKey { get; set; }
        public DateTime? PayDate { get; set; }
        public bool? Active { get; set; }
        public string? SvcStatus { get; set; }
    }
}
