using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmCountry
    {
        public int CountryIndex { get; set; }
        public string CountryId { get; set; } = null!;
        public string? CountryName { get; set; }
        public bool? Active { get; set; }
        public string? SvcStatus { get; set; }
    }
}
