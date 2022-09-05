using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmBreedingSelection
    {
        public long BsIndex { get; set; }
        public string? BsAnimalId { get; set; }
        public string? BsGroup { get; set; }
        public string? BsSubGroup { get; set; }
        public decimal? BsGroupNo { get; set; }
        public string? BsAnimalSource { get; set; }
        public DateTime? BsSelectionDate { get; set; }
        public string? FarmId { get; set; }
        public string? SvcStatus { get; set; }
    }
}
