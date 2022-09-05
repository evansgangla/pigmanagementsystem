using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmStocktakeMst
    {
        public long StockIndex { get; set; }
        public int? StockNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Filter { get; set; }
        public string? Status { get; set; }
        public string? FarmId { get; set; }
        public string? UserId { get; set; }
    }
}
