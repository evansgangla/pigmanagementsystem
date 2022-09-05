using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmStockTakeSlave
    {
        public long StockIndex { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? StockNo { get; set; }
        public string? AnimalId { get; set; }
        public string? Group { get; set; }
        public decimal? GroupNo { get; set; }
        public bool? Printed { get; set; }
        public decimal? CopiesNo { get; set; }
        public string? FarmId { get; set; }
        public string? UserId { get; set; }
    }
}
