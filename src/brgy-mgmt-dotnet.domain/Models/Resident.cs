using brgy_mgmt_dotnet.domain.Enums;
using brgy_mgmt_dotnet.domain.Models.Common;

namespace brgy_mgmt_dotnet.domain.Models
{
    public class Resident : BaseModel
    {
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string? Suffix { get; set; }
        public DateOnly BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string? Nationality { get; set; }
        public string Street { get; set; } = null!;
        public string Barangay { get; set; } = null!;
        public string District { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
    }
}
