using brgy_mgmt_dotnet.application.DTOs.BrgyInfos;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brgy_mgmt_dotnet.application.Features.BrgyInfos.Commands.UpdateBrgyInfo
{
    public class UpdateBrgyInfoCommand : IRequest<ViewBrgyInfoDto?>
    {
        public int Id { get; set; }
        public UpsertBrgyInfoDto UpsertBrgyInfoDto { get; set; } = null!;
    }
}
