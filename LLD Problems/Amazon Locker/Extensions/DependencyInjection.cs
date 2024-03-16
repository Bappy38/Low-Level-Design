using Amazon_Locker.Repositories;
using Amazon_Locker.Services;

namespace Amazon_Locker.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSingleton<ILockerRepository, LockerRepository>();
        services.AddSingleton<IOrderRepository, OrderRepository>();
        services.AddSingleton<ILockerPackageRepository, LockerPackageRepository>();
        services.AddSingleton<INotificationRepository, NotificationRepository>();
        services.AddSingleton<ILockerService, LockerService>();

        services.AddHostedService<NotificationService>();

        return services;
    }
}
