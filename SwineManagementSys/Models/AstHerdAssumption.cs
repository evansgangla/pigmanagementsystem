using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class AstHerdAssumption
    {
        public long AstHaIndex { get; set; }
        public string? AstHaSex { get; set; }
        public string? AstSubGroup { get; set; }
        public decimal? AstHaAgeFrom { get; set; }
        public decimal? AstHaAgeTo { get; set; }
        public decimal? AstHaAge { get; set; }
        public string? AstHaAgeMetric { get; set; }
        public decimal? AstHaWeightFrom { get; set; }
        public decimal? AstHaWeightTo { get; set; }
        public string? AstHaWeightMetric { get; set; }
        public string? AstHaFeedtype { get; set; }
        public decimal? AstHaFeedWeight { get; set; }
        public string? AstHaFeedMetric { get; set; }
        public string? AstHaCycle { get; set; }
        public bool? AstHaActive { get; set; }
        public string? SvcStatus { get; set; }
    }
}
