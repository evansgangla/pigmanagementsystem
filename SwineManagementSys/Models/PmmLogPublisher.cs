using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmLogPublisher
    {
        public long LogIndex { get; set; }
        public string? FarmId { get; set; }
        public string? ModuleName { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? NewRecords { get; set; }
        public int? TotalRecords { get; set; }
    }
}
