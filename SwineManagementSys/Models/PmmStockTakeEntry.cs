using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmStockTakeEntry
    {
        public long StockIndex { get; set; }
        public string? SheetNo { get; set; }
        public decimal? StockNo { get; set; }
        public DateTime? Date { get; set; }
        public string? AnimalId { get; set; }
        public string? Group { get; set; }
        public decimal? Counted { get; set; }
        public string? FarmId { get; set; }
        public string? UserId { get; set; }
    }
}
