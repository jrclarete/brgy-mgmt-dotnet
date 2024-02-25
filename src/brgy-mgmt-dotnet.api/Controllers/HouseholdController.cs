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
    [Route("api/households")]
    [ApiController]
    public class HouseholdController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HouseholdController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<HouseholdController>
        [HttpGet]
        public async Task<IActionResult> GetHouseholdsAsync()
        {
            var residents = await _mediator.Send(new GetResidentsQuery());
            return Ok(residents);
        }

        // GET api/<HouseholdController>/5
        [HttpGet("{id}", Name = nameof(HouseholdController.GetHouseholdById))]
        public async Task<IActionResult> GetHouseholdById(int id)
        {
            var resident = await _mediator.Send(new GetResidentByIdQuery() { Id = id});
            if (resident == null)
            {
                return NotFound();
            }

            return Ok(resident);
        }

        // POST api/<HouseholdController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UpsertResidentDto createResident)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var request = new CreateResidentCommand { UpsertResidentDto = createResident };
            var response = await _mediator.Send(request);

            return CreatedAtAction(nameof(HouseholdController.GetHouseholdById), new { id = response.Id }, response);
        }

        // PUT api/<HouseholdController>/5
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

        // DELETE api/<HouseholdController>/5
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
