using brgy_mgmt_dotnet.application.Contracts.Persistence;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using MapsterMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.Residents.Commands.DeleteResident
{
    public class DeleteResidentCommandHandler : IRequestHandler<DeleteResidentCommand, ViewResidentDto?>
    {
        private readonly IResidentRepository _residentRepository;
        private readonly IMapper _mapper;

        public DeleteResidentCommandHandler(IResidentRepository residentRepository, IMapper mapper)
        {
            _residentRepository = residentRepository;
            _mapper = mapper;
        }

        public async Task<ViewResidentDto?> Handle(DeleteResidentCommand request, CancellationToken cancellationToken)
        {
            var resident = await _residentRepository.Get(request.Id);
            if (resident == null)
            {
                return null;
            }

            resident.IsDeleted = true;

            await _residentRepository.Delete(resident);

            return _mapper.Map<ViewResidentDto>(resident);
        }
    }
}
