using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmAccStockValuation
    {
        public long StockIndex { get; set; }
        public string? AnimalId { get; set; }
        public string? Entry { get; set; }
        public decimal? Quantity { get; set; }
        public string? Units { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalValue { get; set; }
        public string? FarmId { get; set; }
    }
}
