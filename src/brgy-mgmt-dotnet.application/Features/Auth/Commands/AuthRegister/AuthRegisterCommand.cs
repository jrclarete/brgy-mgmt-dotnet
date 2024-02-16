using brgy_mgmt_dotnet.application.DTOs.Auth;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.Auth.Commands.AuthRegister
{
    public class AuthRegisterCommand : IRequest<AuthResponseDto?>
    {
        public AuthRegisterDto AuthRegisterDto { get; set; } = null!;
    }
}
