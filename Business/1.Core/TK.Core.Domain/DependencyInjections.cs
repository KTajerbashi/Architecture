using BaseSource.Core.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace TK.Core.Domain;

public static class DependencyInjections
{
    public static IServiceCollection AddDomain(this IServiceCollection service)
    {
        service.AddBaseDomain();
        return service;
    }
}
