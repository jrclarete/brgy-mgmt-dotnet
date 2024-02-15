using brgy_mgmt_dotnet.domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace brgy_mgmt_dotnet.application.DTOs.Residents
{
    public class BaseResidentDto
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [StringLength(50)]
        public string? MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [StringLength(10)]
        public string? Suffix { get; set; }

        [Required]
        public DateOnly BirthDate { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Gender Gender { get; set; }

        [StringLength(20)]
        public string? Nationality { get; set; }

        [Required]
        [StringLength(500)]
        public string Street { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Barangay { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string District { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string State { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string ZipCode { get; set; } = null!;
    }
}
