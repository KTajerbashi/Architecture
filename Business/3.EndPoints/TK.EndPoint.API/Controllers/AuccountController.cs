using BaseSource.EndPoint.Controllers;
using MediatR;
using System.Net;

namespace TK.EndPoint.API.Controllers;

public class AuccountController : AuthorizationController
{
    public AuccountController(IMediator mediator) : base(mediator)
    {
    }
}




