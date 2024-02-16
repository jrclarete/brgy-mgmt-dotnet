using brgy_mgmt_dotnet.application.Contracts.Auth;
using brgy_mgmt_dotnet.application.Contracts.Persistence;
using brgy_mgmt_dotnet.application.DTOs.Auth;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using brgy_mgmt_dotnet.application.Features.Residents.Commands.CreateResident;
using brgy_mgmt_dotnet.domain.Models;
using MapsterMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.Auth.Commands.AuthRegister
{
    public class AuthRegisterCommandHandler : IRequestHandler<AuthRegisterCommand, AuthResponseDto?>
    {
        private readonly IAuthRepository _authRepository;
        private readonly IMapper _mapper;

        public AuthRegisterCommandHandler(IAuthRepository authRepository, IMapper mapper)
        {
            _authRepository = authRepository;
            _mapper = mapper;
        }

        public async Task<AuthResponseDto?> Handle(AuthRegisterCommand request, CancellationToken cancellationToken)
        {
            var authReponse = await _authRepository.Register(request.AuthRegisterDto);

            return _mapper.Map<AuthResponseDto>(authReponse);
        }
    }
}
