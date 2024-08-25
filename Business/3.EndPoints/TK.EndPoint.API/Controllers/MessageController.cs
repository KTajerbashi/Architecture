using MediatR;

namespace TK.EndPoint.API.Controllers;

public class MessageController : AuthenticateController
{
    public MessageController(IMediator mediator) : base(mediator)
    {
    }
}