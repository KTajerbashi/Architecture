using BaseSource.Infrastructure.Data.Sql.Query;
using Microsoft.Extensions.DependencyInjection;

namespace TK.Infrastructure.Data.Sql.Query;

public static class DependencyInjections
{
    public static IServiceCollection AddSQLQuery(this IServiceCollection service)
    {
        service.AddBaseQuerySQL();
        return service;
    }
}
