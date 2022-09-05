using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmAccGlLog
    {
        public long GlIndex { get; set; }
        public string? RefNo { get; set; }
        public DateTime? GlDate { get; set; }
        public string? GlSource { get; set; }
        public string? GlTranType { get; set; }
        public string? GlDescription { get; set; }
        public string? GlItem { get; set; }
        public decimal? GlQuantity { get; set; }
        public string? GlUnit { get; set; }
        public decimal? CostPerUnit { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? PaidValue { get; set; }
        public decimal? BalanceValue { get; set; }
        public string? PayMode { get; set; }
        public string? ChequeNo { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public decimal? PenalRate { get; set; }
        public string? GlDrCr { get; set; }
        public string? DrAcc { get; set; }
        public string? CrAcc { get; set; }
        public string? FarmId { get; set; }
        public bool? Active { get; set; }
    }
}
