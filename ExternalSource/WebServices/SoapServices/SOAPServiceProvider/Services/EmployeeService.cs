using SOAPServiceProvider.Models;

namespace SOAPServiceProvider.Services;

public class EmployeeService : IEmployeeService
{
    public OrganizationContract GetOrganizationContract()
    {
        ManagerContract manager = new ManagerContract()
        {
            Id = 1,
            Email = "",
            Key = Guid.NewGuid(),
            IsAccess = true,
            Password = Guid.NewGuid().ToString("D"),
            Phone = ""
        };
        var organization = new OrganizationContract
        {
            Key = Guid.NewGuid(),
            Name = "Organization"
        };
        return organization;
    }
}


