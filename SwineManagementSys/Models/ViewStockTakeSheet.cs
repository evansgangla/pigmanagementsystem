using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class ViewStockTakeSheet
    {
        public DateTime? StartDate { get; set; }
        public decimal? StockNo { get; set; }
        public string? AnimalId { get; set; }
        public string? Group { get; set; }
        public int? Counted { get; set; }
        public string? FarmId { get; set; }
        public string? FarmName { get; set; }
        public string? FarmCounty { get; set; }
    }
}
