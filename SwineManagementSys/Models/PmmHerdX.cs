using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmHerdX
    {
        public long HcIndex { get; set; }
        public string? HcAnimalId { get; set; }
        public string? HcGroup { get; set; }
        public string? HcParentSow { get; set; }
        public decimal? HcGroupNo { get; set; }
        public DateTime? HcDateBorn { get; set; }
        public string? HcFarmId { get; set; }
        public bool? HcActive { get; set; }
    }
}
