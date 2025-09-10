using Microsoft.Extensions.DependencyInjection;

namespace BaseSource.Infrastructure.Data.Sql.Query;

public static class DependencyInjections
{
    public static IServiceCollection AddBaseQuerySQL(this IServiceCollection service)
    {
        return service;
    }
}
