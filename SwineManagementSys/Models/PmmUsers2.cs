using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmUsers2
    {
        public long UserIndex { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public string? UserFname { get; set; }
        public string? UserOname { get; set; }
        public string? GroupName { get; set; }
        public bool? UserActive { get; set; }
        public string? FarmId { get; set; }
    }
}
