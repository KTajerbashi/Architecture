using Microsoft.Extensions.DependencyInjection;

namespace BaseSource.Infrastructure.Data.Sql.Command;

public static class DependencyInjections
{
    public static IServiceCollection AddBaseCommandSQL(this IServiceCollection service)
    {
        return service;
    }
}
