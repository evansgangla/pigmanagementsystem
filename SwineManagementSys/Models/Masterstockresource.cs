using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class Masterstockresource
    {
        public string? FarmId { get; set; }
        public int? Indx { get; set; }
        public string? ClosingBalance { get; set; }
        public string? DateOfIssue { get; set; }
        public string? Destination { get; set; }
        public string? IssuePrice { get; set; }
        public string? IssuedBy { get; set; }
        public string? Metric { get; set; }
        public string? OpeningBalance { get; set; }
        public string? OriginalStore { get; set; }
        public string? Quantity { get; set; }
        public string? ReorderLevel { get; set; }
        public string? ResourceName { get; set; }
        public string? ResourceType { get; set; }
    }
}
