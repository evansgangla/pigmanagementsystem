using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmBreedingCulling
    {
        public long BcIndex { get; set; }
        public string? BcReferenceNo { get; set; }
        public string? BcAnimalId { get; set; }
        public string? BcGroup { get; set; }
        public string? BcSubGroup { get; set; }
        public decimal? BcGroupNo { get; set; }
        public string? BcSource { get; set; }
        public string? BcReasons { get; set; }
        public DateTime? BcDate { get; set; }
        public string? FarmId { get; set; }
        public string? BcCullType { get; set; }
        public string? SvcStatus { get; set; }
    }
}
