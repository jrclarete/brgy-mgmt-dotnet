using brgy_mgmt_dotnet.application.DTOs.Residents;
using MediatR;

namespace brgy_mgmt_dotnet.application.Features.Residents.Commands.UpdateResident
{
    public class UpdateResidentCommand : IRequest<ViewResidentDto?>
    {
        public int Id { get; set; }
        public UpsertResidentDto UpsertResidentDto { get; set; } = null!;
    }
}
