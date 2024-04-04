using Microsoft.EntityFrameworkCore;
using Repository_Pattern.Repositories;

namespace Repository_Pattern.Extensions;

public static class ServiceRegisterExtension
{

    public static IServiceCollection ConfigureSqlConnection(this IServiceCollection services,
        IConfiguration configuration)
    {
        var sqlConnectionString = configuration.GetConnectionString("SqlConnection");

        services.AddDbContext<RepositoryContext>(opts =>
        {
            opts.UseSqlServer(sqlConnectionString, sqlServerAction =>
            {
                sqlServerAction.EnableRetryOnFailure(3);
                sqlServerAction.CommandTimeout(30);
            });
        });
        return services;
    }

    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<RepositoryContext>();
        services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        return services;
    }
}