using SharedKernel.Extensions.Providers.CacheSystem;
using SharedKernel.Extensions.Providers.Logger;
using SharedKernel.Extensions.Providers.Mapper;
using SharedKernel.Extensions.Providers.Serializers;

namespace SharedKernel.Extensions.Providers;

public static class DependencyInjections
{
    public static IServiceCollection AddProviders(this IServiceCollection service)
    {

        service.AddSerializer();
        
        service.AddCacheSystem();
        
        service.AddLogger();
        
        service.AddMapper();

        service.AddScoped<ProviderFactory>();

        return service;
    }
}
