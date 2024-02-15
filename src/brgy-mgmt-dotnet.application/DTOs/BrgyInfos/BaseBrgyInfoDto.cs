using brgy_mgmt_dotnet.domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.DTOs.BrgyInfos
{
    public class BaseBrgyInfoDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(500)]
        public string Street { get; set; } = null!;

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
