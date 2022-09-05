using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmStockTakeUpdate
    {
        public long StockIndex { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? StockNo { get; set; }
        public string? Filter { get; set; }
        public string? AnimalId { get; set; }
        public string? Group { get; set; }
        public decimal? PreCountNo { get; set; }
        public decimal? CountedNo { get; set; }
        public decimal? VarianceNo { get; set; }
        public string? FarmId { get; set; }
        public string? UserId { get; set; }
    }
}
