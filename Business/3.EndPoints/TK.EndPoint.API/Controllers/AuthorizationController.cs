using Microsoft.AspNetCore.Mvc;
using SOAP_EmployeeService;

namespace TK.EndPoint.API.Controllers;

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
