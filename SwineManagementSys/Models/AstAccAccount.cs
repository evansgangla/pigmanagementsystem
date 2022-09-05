using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class AstAccAccount
    {
        public long AccIndex { get; set; }
        public string? AccId { get; set; }
        public string? AccDescription { get; set; }
        public bool? Active { get; set; }
    }
}
