using Microsoft.Extensions.DependencyInjection;

namespace BaseSource.Core.ApplicationService;

public static class DependencyInjections
{
    public static IServiceCollection AddBaseApplicationService(this IServiceCollection service)
    {
        return service;
    }
}
