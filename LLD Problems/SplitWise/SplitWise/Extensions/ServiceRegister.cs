using Microsoft.EntityFrameworkCore;
using SplitWise.Data;
using SplitWise.Repositories;

namespace SplitWise.Extensions;

public static class ServiceRegister
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IExpenseRepository, ExpenseRepository>();

        return services;
    }
}