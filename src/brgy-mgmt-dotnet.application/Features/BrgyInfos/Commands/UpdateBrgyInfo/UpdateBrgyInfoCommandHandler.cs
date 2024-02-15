using brgy_mgmt_dotnet.application.Contracts.Persistence;
using brgy_mgmt_dotnet.application.DTOs.BrgyInfos;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using brgy_mgmt_dotnet.application.Features.Residents.Commands.UpdateResident;
using MapsterMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.BrgyInfos.Commands.UpdateBrgyInfo
{
    public class UpdateBrgyInfoCommandHandler : IRequestHandler<UpdateBrgyInfoCommand, ViewBrgyInfoDto?>
    {
        private readonly IBrgyInfoRepository _brgyInfoRepository;
        private readonly IMapper _mapper;


        public UpdateBrgyInfoCommandHandler(IBrgyInfoRepository brgyInfoRepository, IMapper mapper)
        {
            _brgyInfoRepository = brgyInfoRepository;
            _mapper = mapper;
        }


        public async Task<ViewBrgyInfoDto?> Handle(UpdateBrgyInfoCommand request, CancellationToken cancellationToken)
        {
            var brgyInfo = await _brgyInfoRepository.Get(request.Id);
            if (brgyInfo == null)
            {
                return null;
            }

            _mapper.Map(request.UpsertBrgyInfoDto, brgyInfo);
            brgyInfo.UpdatedBy = "TEST";
            brgyInfo.DateUpdated = DateTime.Now;

            await _brgyInfoRepository.Update(brgyInfo);

            return _mapper.Map<ViewBrgyInfoDto>(brgyInfo);
        }
    }
}
