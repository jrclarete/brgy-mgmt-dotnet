using brgy_mgmt_dotnet.application.DTOs.Residents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.Residents.Commands.DeleteResident
{
    public class DeleteResidentCommand : IRequest<ViewResidentDto?>
    {
        public int Id { get; set; }
    }
}
