using brgy_mgmt_dotnet.application.Contracts.Auth;
using brgy_mgmt_dotnet.application.DTOs.Auth;
using brgy_mgmt_dotnet.application.Features.Auth.Commands.AuthRegister;
using MapsterMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.Auth.Queries.AuthLogin
{
    public class AuthLoginQueryHandler : IRequestHandler<AuthLoginQuery, AuthResponseDto?>
    {
        private readonly IAuthRepository _authRepository;
        private readonly IMapper _mapper;

        public AuthLoginQueryHandler(IAuthRepository authRepository, IMapper mapper)
        {
            _authRepository = authRepository;
            _mapper = mapper;
        }

        public async Task<AuthResponseDto?> Handle(AuthLoginQuery request, CancellationToken cancellationToken)
        {
            var authReponse = await _authRepository.Login(request.AuthLoginDto);

            return _mapper.Map<AuthResponseDto>(authReponse);
        }
    }
}
