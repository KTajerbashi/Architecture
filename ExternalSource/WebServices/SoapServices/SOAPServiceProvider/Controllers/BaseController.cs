using Microsoft.AspNetCore.Mvc;

namespace SOAPServiceProvider.Controllers;

[ApiController]
[Route("soap/[controller]")]
public class BaseController : Controller
{

}

public class AuthorizationController : BaseController
{

}

public class MessageController : BaseController
{

}