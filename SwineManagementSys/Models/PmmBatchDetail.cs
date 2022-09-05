using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmBatchDetail
    {
        public long BatchDetailIndex { get; set; }
        public string? BatchId { get; set; }
        public DateTime? BatchingDate { get; set; }
        public string? BatchingGroup { get; set; }
        public string? BatchingAnimalId { get; set; }
        public DateTime? BatchingDateBorn { get; set; }
        public decimal? BatchingGroupNo { get; set; }
        public decimal? BatchingGroupWeight { get; set; }
        public string? BatchParentBoar { get; set; }
        public string? BatchParentSow { get; set; }
        public string? BreedType { get; set; }
        public bool? Active { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
