using brgy_mgmt_dotnet.application.Contracts.Persistence;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using brgy_mgmt_dotnet.domain.Models;
using MapsterMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.Residents.Commands.CreateResident
{
    public class CreateResidentCommandHandler : IRequestHandler<CreateResidentCommand, ViewResidentDto>
    {
        private readonly IResidentRepository _residentRepository;
        private readonly IMapper _mapper;

        public CreateResidentCommandHandler(IResidentRepository residentRepository, IMapper mapper)
        {
            _residentRepository = residentRepository;
            _mapper = mapper;
        }

        public async Task<ViewResidentDto> Handle(CreateResidentCommand request, CancellationToken cancellationToken)
        {
            var resident = _mapper.Map<Resident>(request.UpsertResidentDto);
            resident.CreatedBy = "TEST";
            resident.DateCreated = DateTime.Now;

            await _residentRepository.Add(resident);

            return _mapper.Map<ViewResidentDto>(resident);
        }
    }
}
