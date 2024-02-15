using brgy_mgmt_dotnet.application.Contracts.Persistence;
using brgy_mgmt_dotnet.application.DTOs.BrgyInfos;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using MapsterMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.BrgyInfos.Queries.GetBrgyInfos
{
    public class GetBrgyInfosQueryHandler : IRequestHandler<GetBrgyInfosQuery, ViewBrgyInfoDto?>
    {
        private readonly IBrgyInfoRepository _brgyInfoRepository;
        private readonly IMapper _mapper;

        public GetBrgyInfosQueryHandler(IBrgyInfoRepository brgyInfoRepository, IMapper mapper)
        {
            _brgyInfoRepository = brgyInfoRepository;
            _mapper = mapper;
        } 

        public async Task<ViewBrgyInfoDto?> Handle(GetBrgyInfosQuery request, CancellationToken cancellationToken)
        {
            var brgyInfo = await _brgyInfoRepository.Get();
            if (brgyInfo == null)
            {
                return null;
            }
            return _mapper.Map<ViewBrgyInfoDto>(brgyInfo);
        }
    }
}
