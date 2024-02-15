using brgy_mgmt_dotnet.application.DTOs.Residents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.Residents.Commands.CreateResident
{
    public class CreateResidentCommand : IRequest<ViewResidentDto>
    {
        public UpsertResidentDto UpsertResidentDto { get; set; } = null!;
    }
}
