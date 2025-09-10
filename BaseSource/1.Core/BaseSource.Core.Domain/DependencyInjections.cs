using Microsoft.Extensions.DependencyInjection;

namespace BaseSource.Core.Domain;

public static class DependencyInjections
{
    public static IServiceCollection AddBaseDomain(this IServiceCollection service)
    {
        return service;
    }
}
