using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class AstAccLedger
    {
        public long AccSettingIndex { get; set; }
        public string? AccTransactionType { get; set; }
        public string? AccPaymode { get; set; }
        public string? DrLedger { get; set; }
        public string? CrLedger { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? SvcStatus { get; set; }
        public string? FarmId { get; set; }
        public bool? Active { get; set; }
    }
}
