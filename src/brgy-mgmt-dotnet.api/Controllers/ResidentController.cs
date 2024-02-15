using brgy_mgmt_dotnet.application.DTOs.Residents;
using brgy_mgmt_dotnet.application.Features.Residents.Commands.CreateResident;
using brgy_mgmt_dotnet.application.Features.Residents.Commands.DeleteResident;
using brgy_mgmt_dotnet.application.Features.Residents.Commands.UpdateResident;
using brgy_mgmt_dotnet.application.Features.Residents.Queries.GetResidentById;
using brgy_mgmt_dotnet.application.Features.Residents.Queries.GetResidents;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace brgy_mgmt_dotnet.api.Controllers
{
    [Route("api/residents")]
    [ApiController]
    public class ResidentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ResidentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<ResidentController>
        [HttpGet]
        public async Task<IActionResult> GetResidentsAsync()
        {
            var residents = await _mediator.Send(new GetResidentsQuery());
            return Ok(residents);
        }

        // GET api/<ResidentController>/5
        [HttpGet("{id}", Name = nameof(ResidentController.GetResidentById))]
        public async Task<IActionResult> GetResidentById(int id)
        {
            var resident = await _mediator.Send(new GetResidentByIdQuery() { Id = id});
            if (resident == null)
            {
                return NotFound();
            }

            return Ok(resident);
        }

        // POST api/<ResidentController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UpsertResidentDto createResident)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var request = new CreateResidentCommand { UpsertResidentDto = createResident };
            var response = await _mediator.Send(request);

            return CreatedAtAction(nameof(ResidentController.GetResidentById), new { id = response.Id }, response);
        }

        // PUT api/<ResidentController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] UpsertResidentDto updateResident)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var request = new UpdateResidentCommand { Id = id, UpsertResidentDto = updateResident };
            var response = await _mediator.Send(request);

            if (response == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE api/<ResidentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var request = new DeleteResidentCommand { Id = id };
            var response = await _mediator.Send(request);

            if (response == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
