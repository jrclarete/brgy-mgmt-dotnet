using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.DTOs.Auth
{
    public class AuthRegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [MinLength(4)]
        public string UserName { get; set; } = null!;

        [Required]
        [MinLength(6)]
        public string Password { get; set; } = null!;
    }
}
