using brgy_mgmt_dotnet.application.DTOs.Auth;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.Auth.Queries.AuthLogin
{
    public class AuthLoginQuery : IRequest<AuthResponseDto?>
    {
        public AuthLoginDto AuthLoginDto { get; set; } = null!;
    }
}
