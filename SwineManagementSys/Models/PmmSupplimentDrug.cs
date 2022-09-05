using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmSupplimentDrug
    {
        public long SdIndex { get; set; }
        public DateTime? SdDate { get; set; }
        public string? SdAnimalId { get; set; }
        public string? SdGroup { get; set; }
        public decimal? SdGroupNo { get; set; }
        public string? SdName { get; set; }
        public string? SdType { get; set; }
        public decimal? SdQuantityPerAnimal { get; set; }
        public string? SdUnit { get; set; }
        public decimal? SdCostPerKg { get; set; }
        public decimal? SdCostPerAnimal { get; set; }
        public decimal? SdTotalQuantity { get; set; }
        public decimal? SdTotalCost { get; set; }
        public bool? SdActive { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
