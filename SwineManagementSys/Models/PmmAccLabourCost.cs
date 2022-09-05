using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmAccLabourCost
    {
        public long LabourIndex { get; set; }
        public DateTime? LabourDate { get; set; }
        public string? AnimalId { get; set; }
        public decimal? NoOfAnimals { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalCost { get; set; }
        public string? FarmId { get; set; }
    }
}
