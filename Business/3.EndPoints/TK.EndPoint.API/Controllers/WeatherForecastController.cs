using Microsoft.AspNetCore.Mvc;
using SOAP_EmployeeService;

namespace TK.EndPoint.API.Controllers;
[ApiController]
[Route("soap/[controller]")]
public class BaseController : Controller
{

}

public class AuthorizationController : BaseController
{
    [HttpGet("GetEmployeeInfo")]
    public async Task<IActionResult> GetEmployeeInfo()
    {
        IEmployeeService employeeService = new EmployeeServiceClient(EmployeeServiceClient.EndpointConfiguration.BasicHttpBinding_IEmployeeService);
        var result = employeeService.GetOrganizationContract();
        return await Task.FromResult(Ok(result));
    }
}

public class MessageController : BaseController
{

}