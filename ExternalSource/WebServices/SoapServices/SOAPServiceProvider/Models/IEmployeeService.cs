using System.ServiceModel;

namespace SOAPServiceProvider.Models;

[ServiceContract]
public interface IEmployeeService
{
    [OperationContract]
    OrganizationContract GetOrganizationContract();
}

