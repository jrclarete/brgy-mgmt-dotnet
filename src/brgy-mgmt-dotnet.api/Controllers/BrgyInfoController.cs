using brgy_mgmt_dotnet.application.DTOs.BrgyInfos;
using brgy_mgmt_dotnet.application.DTOs.Residents;
using brgy_mgmt_dotnet.application.Features.BrgyInfos.Commands.UpdateBrgyInfo;
using brgy_mgmt_dotnet.application.Features.BrgyInfos.Queries.GetBrgyInfos;
using brgy_mgmt_dotnet.application.Features.Residents.Commands.UpdateResident;
using brgy_mgmt_dotnet.application.Features.Residents.Queries.GetResidents;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace brgy_mgmt_dotnet.api.Controllers
{
    [Route("api/brgy-info")]
    [ApiController]
    [Authorize(Policy = "BrgyInfoClaimBasedPolicy")]
    public class BrgyInfoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrgyInfoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<BrgyInfoController>
        [HttpGet]
        [Authorize(Policy = "BrgyInfoReadPolicy")]
        public async Task<IActionResult> GetBrgyInfoAsync()
        {
            var brgyInfo = await _mediator.Send(new GetBrgyInfosQuery());
            return Ok(brgyInfo);
        }

        // PUT api/<BrgyInfoController>/5
        [HttpPut("{id}")]
        [Authorize(Policy = "BrgyInfoReadPolicy")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] UpsertBrgyInfoDto updateBrgyInfo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var request = new UpdateBrgyInfoCommand { Id = id, UpsertBrgyInfoDto = updateBrgyInfo };
            var response = await _mediator.Send(request);

            if (response == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
