using Microsoft.EntityFrameworkCore;
using SplitWise.Data;
using SplitWise.Repositories;

namespace SplitWise.Extensions;

public static class ServiceRegister
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddDbContext<RepositoryContext>(opt => opt.UseInMemoryDatabase("InMemoryDb"));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IExpenseRepository, ExpenseRepository>();
        return services;
    }
}