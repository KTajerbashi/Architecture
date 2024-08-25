using Microsoft.AspNetCore.Mvc;


using MediatR;

namespace BaseSource.EndPoint.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController : Controller
{
    protected IMediator Mediator;

    protected BaseController(IMediator mediator)
    {
        Mediator = mediator;
    }
}
