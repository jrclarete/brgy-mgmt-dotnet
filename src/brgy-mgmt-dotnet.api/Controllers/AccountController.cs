using brgy_mgmt_dotnet.application.Contracts.Auth;
using brgy_mgmt_dotnet.application.DTOs.Auth;
using brgy_mgmt_dotnet.application.Features.Auth.Commands.AuthRegister;
using brgy_mgmt_dotnet.application.Features.Auth.Queries.AuthLogin;
using brgy_mgmt_dotnet.application.Features.Residents.Commands.CreateResident;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace brgy_mgmt_dotnet.api.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] AuthRegisterDto register)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var request = new AuthRegisterCommand { AuthRegisterDto = register };
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> login([FromBody] AuthLoginDto login)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var request = new AuthLoginQuery { AuthLoginDto = login };
            var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
