using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmSupplier
    {
        public long SupplierIndex { get; set; }
        public string? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierPhone { get; set; }
        public string? SupplierEmail { get; set; }
        public string? SupplierTown { get; set; }
        public string? County { get; set; }
        public string? ParentFarm { get; set; }
        public string? FarmName { get; set; }
        public bool? Active { get; set; }
        public string? SvcStatus { get; set; }
    }
}
