using brgy_mgmt_dotnet.application.Contracts.Persistence;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using MapsterMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.Residents.Queries.GetResidents
{
    public class GetResidentsQueryHandler : IRequestHandler<GetResidentsQuery, List<ViewResidentDto>>
    {
        private readonly IResidentRepository _residentRepository;
        private readonly IMapper _mapper;

        public GetResidentsQueryHandler(IResidentRepository residentRepository, IMapper mapper)
        {
            _residentRepository = residentRepository;
            _mapper = mapper;
        }

        public async Task<List<ViewResidentDto>> Handle(GetResidentsQuery request, CancellationToken cancellationToken)
        {
            var residents = await _residentRepository.GetAll();
            return _mapper.Map<List<ViewResidentDto>>(residents);
        }
    }
}
