using BaseSource.Infrastructure.Data.Sql.Command;
using Microsoft.Extensions.DependencyInjection;

namespace TK.Infrastructure.Data.Sql.Command;

public static class DependencyInjections
{
    public static IServiceCollection AddSQLCommand(this IServiceCollection service)
    {
        service.AddBaseCommandSQL();
        return service;
    }
}
