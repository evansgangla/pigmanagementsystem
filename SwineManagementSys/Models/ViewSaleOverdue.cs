using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class ViewSaleOverdue
    {
        public string? HcAnimalId { get; set; }
        public int? Age { get; set; }
        public string? HcGroup { get; set; }
        public decimal? HcGroupNo { get; set; }
        public decimal? HcWeight { get; set; }
        public DateTime? ExpSaleDate { get; set; }
        public int? OverSaleDays { get; set; }
        public string? FarmId { get; set; }
        public string? FarmName { get; set; }
        public string? FarmCounty { get; set; }
    }
}
