using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmEconomyLog
    {
        public long ElIndex { get; set; }
        public DateTime? ElDate { get; set; }
        public string? ElReferenceNo { get; set; }
        public string? ElSourceModule { get; set; }
        public string? ElDescription { get; set; }
        public decimal? ElQuantity { get; set; }
        public decimal? ElUnitCost { get; set; }
        public decimal? ElValue { get; set; }
        public bool? ElActive { get; set; }
        public string? FarmId { get; set; }
    }
}
