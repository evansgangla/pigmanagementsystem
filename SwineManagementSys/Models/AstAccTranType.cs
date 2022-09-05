using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class AstAccTranType
    {
        public long TranTypeIndex { get; set; }
        public string? TranTypeId { get; set; }
        public string? TranType { get; set; }
        public bool? Active { get; set; }
    }
}
