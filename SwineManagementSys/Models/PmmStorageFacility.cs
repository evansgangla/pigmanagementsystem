using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmStorageFacility
    {
        public string? Indx { get; set; }
        public DateTime? DateAdded { get; set; }
        public string? Dimensions { get; set; }
        public string? FarmId { get; set; }
        public string? Purpose { get; set; }
        public string? StorageCapacity { get; set; }
        public string? StoreId { get; set; }
    }
}
