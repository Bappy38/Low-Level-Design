using Meeting_Scheduler.Services;

namespace Meeting_Scheduler.Extensions;

public static class ServiceRegistration
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSingleton<INotificationSender, EmailNotificationSender>();
        services.AddSingleton<INotificationSender, PushNotificationSender>();
        services.AddSingleton<NotificationManager>();

        services.AddSingleton<IMeetingScheduler, MeetingScheduler>();

        return services;
    }
}
