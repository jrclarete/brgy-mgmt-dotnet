using brgy_mgmt_dotnet.application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Contracts.Auth
{
    public interface IAuthRepository
    {
        Task<AuthResponseDto?> Login(AuthLoginDto request);
        Task<AuthResponseDto?> Register(AuthRegisterDto request);
    }
}
