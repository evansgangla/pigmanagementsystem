using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmHerdBreedType
    {
        public long BreedIndex { get; set; }
        public string? FarmId { get; set; }
        public string? BreedName { get; set; }
        public string? BreedDescription { get; set; }
        public byte[]? BreedImage { get; set; }
        public string? SvcStatus { get; set; }
        public bool? Active { get; set; }
    }
}
