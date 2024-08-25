using BaseSource.EndPoint.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TK.EndPoint.API.Controllers;

public class AuthenticateController : BaseController
{
    public AuthenticateController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("Login")]
    public async Task<IActionResult> LoginAsync()
    {
        return await Task.FromResult(Ok());
    }

    [HttpGet("Logout")]
    public async Task<IActionResult> LogoutAsync()
    {
        return await Task.FromResult(Ok());
    }


}




