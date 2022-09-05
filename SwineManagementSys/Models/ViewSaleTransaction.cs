using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class ViewSaleTransaction
    {
        public DateTime? StDate { get; set; }
        public string? StAnimalId { get; set; }
        public string? StGroup { get; set; }
        public decimal? StGroupNo { get; set; }
        public DateTime? StExpSaleDtFrom { get; set; }
        public DateTime? StExpSaleDtTo { get; set; }
        public bool? StLiveOrdressed { get; set; }
        public decimal? StNoSold { get; set; }
        public decimal? StExpLivePrice { get; set; }
        public decimal? StExpLiveWt { get; set; }
        public decimal? StExpLiveValue { get; set; }
        public decimal? StExpTotalLiveWt { get; set; }
        public decimal? StExpTotalLiveValue { get; set; }
        public decimal? StExpDressingPer { get; set; }
        public decimal? StExpDressedWt { get; set; }
        public decimal? StExpDressedPrice { get; set; }
        public decimal? StExpDressedValue { get; set; }
        public decimal? StExpDressedTotalWt { get; set; }
        public decimal? StExpDressedTotalValue { get; set; }
        public decimal? StCurLivePrice { get; set; }
        public decimal? StCurLiveWt { get; set; }
        public decimal? StCurLiveValue { get; set; }
        public decimal? StCurTotalLiveWt { get; set; }
        public decimal? StCurTotalLiveValue { get; set; }
        public decimal? StCurDressingPer { get; set; }
        public decimal? StCurDressedWt { get; set; }
        public decimal? StCurDressedPrice { get; set; }
        public decimal? StCurDressedValue { get; set; }
        public decimal? StCurDressedTotalWt { get; set; }
        public decimal? StCurDressedTotalValue { get; set; }
        public string? FarmId { get; set; }
        public string? FarmName { get; set; }
        public string? FarmCounty { get; set; }
    }
}
