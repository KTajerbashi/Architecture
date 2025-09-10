using BaseSource.Core.ApplicationService;
using Microsoft.Extensions.DependencyInjection;

namespace TK.Core.ApplicationService;

public static class DependencyInjections
{
    public static IServiceCollection AddApplicationService(this IServiceCollection service)
    {
        service.AddBaseApplicationService();
        return service;
    }
}
