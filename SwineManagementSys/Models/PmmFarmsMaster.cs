using System;
using System.Collections.Generic;

namespace SwineManagementSys.Models
{
    public partial class PmmFarmsMaster
    {
        public long FarmIndex { get; set; }
        public string FarmId { get; set; } = null!;
        public string? FarmName { get; set; }
        public string? FarmAddress { get; set; }
        public string? FarmTelephone { get; set; }
        public string? FarmEmail { get; set; }
        public string? FarmContactPerson { get; set; }
        public string? FarmLocation { get; set; }
        public string? FarmCounty { get; set; }
        public string? FarmCountry { get; set; }
        public string? FarmTown { get; set; }
        public string? MainFarmId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? FarmActive { get; set; }
        public string? SvcStatus { get; set; }
        public Guid? UniqueId { get; set; }
        public string? TatooPrefix { get; set; }
        public string? GeoTag { get; set; }
        public byte[]? Size { get; set; }
        public byte[]? UoM { get; set; }
        public string? ManagerFirstName { get; set; }
        public string? ManagerMiddleName { get; set; }
        public string? ManagerLastName { get; set; }
        public string? ManagerPhoneNumber { get; set; }
        public string? ManagerEmailAddress { get; set; }
        public string? ManagerAlternateEmail { get; set; }
        public string? TatooLength { get; set; }
        public string? FarmStore { get; set; }
    }
}
