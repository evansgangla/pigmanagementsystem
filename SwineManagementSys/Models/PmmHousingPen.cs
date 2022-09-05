using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmHousingPen
    {
        public string? FarmId { get; set; }
        public string? PenId { get; set; }
        public string? AccomodationSize { get; set; }
        public string? CurrentPopulation { get; set; }
        public string? Dimensions { get; set; }
        public string? Feeders { get; set; }
        public string? FeedingTroughs { get; set; }
        public int? Indx { get; set; }
        public string? Purpose { get; set; }
        public string? Waterers { get; set; }
    }
}
