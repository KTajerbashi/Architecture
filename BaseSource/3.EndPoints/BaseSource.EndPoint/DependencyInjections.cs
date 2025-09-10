using Microsoft.Extensions.DependencyInjection;
//using SharedKernel.Extensions.Providers;

namespace BaseSource.EndPoint;

public static class DependencyInjections
{
    public static IServiceCollection AddBaseEndPoint(this IServiceCollection service)
    {
        //service.AddProviders();
        return service;
    }
}
