using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmAccWriteoff
    {
        public long Index { get; set; }
        public string? GlRefNo { get; set; }
        public decimal? OpeningBal { get; set; }
        public DateTime? Date { get; set; }
        public string? GlTranType { get; set; }
        public string? GlItem { get; set; }
        public string? Details { get; set; }
        public string? Source { get; set; }
        public string? DrCr { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ClosingBal { get; set; }
        public DateTime? ClosingDate { get; set; }
        public string? FarmId { get; set; }
        public bool? Active { get; set; }
    }
}
