using brgy_mgmt_dotnet.application.Contracts.Persistence;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using brgy_mgmt_dotnet.domain.Models;
using MapsterMapper;
using MediatR;

namespace brgy_mgmt_dotnet.application.Features.Residents.Commands.UpdateResident
{
    public class UpdateResidentCommandHandler : IRequestHandler<UpdateResidentCommand, ViewResidentDto?>
    {
        private readonly IResidentRepository _residentRepository;
        private readonly IMapper _mapper;

        public UpdateResidentCommandHandler(IResidentRepository residentRepository, IMapper mapper)
        {
            _residentRepository = residentRepository;
            _mapper = mapper;
        }

        public async Task<ViewResidentDto?> Handle(UpdateResidentCommand request, CancellationToken cancellationToken)
        {
            var resident = await _residentRepository.Get(request.Id);
            if (resident == null)
            {
                return null;
            }

            _mapper.Map(request.UpsertResidentDto, resident);
            resident.UpdatedBy = "TEST";
            resident.DateUpdated = DateTime.Now;

            await _residentRepository.Update(resident);

            return _mapper.Map<ViewResidentDto>(resident);
        }
    }
}
