using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmSalesPlan
    {
        public long SpIndex { get; set; }
        public string? AnimalId { get; set; }
        public string? BatchId { get; set; }
        public DateTime? Dob { get; set; }
        public string? Group { get; set; }
        public decimal? NoAvailable { get; set; }
        public DateTime? SaleDateFrom { get; set; }
        public decimal? NoSold { get; set; }
        public DateTime? SaleDateTo { get; set; }
        public decimal? LiveWtPerAnimal { get; set; }
        public decimal? LiveWtPerGroup { get; set; }
        public decimal? LiveWtPrice { get; set; }
        public decimal? LiveValuePerAnimal { get; set; }
        public decimal? LiveValuePerGroup { get; set; }
        public decimal? DressingPer { get; set; }
        public decimal? DressedwtPerAnimal { get; set; }
        public decimal? DressedwtPerGroup { get; set; }
        public decimal? DressedWtPrice { get; set; }
        public decimal? DressedValuePerAnimal { get; set; }
        public decimal? DressedValuePerGroup { get; set; }
        public string? FarmId { get; set; }
    }
}
