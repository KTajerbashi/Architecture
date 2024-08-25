

using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace BaseSource.EndPoint.Controllers;

[Authorize]
public abstract class AuthorizationController : BaseController
{
    protected AuthorizationController(IMediator mediator) : base(mediator)
    {
    }
}
