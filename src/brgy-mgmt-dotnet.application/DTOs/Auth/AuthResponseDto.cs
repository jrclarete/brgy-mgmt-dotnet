using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.DTOs.Auth
{
    public class AuthResponseDto
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string Token { get; set; } = null!;
    }
}
