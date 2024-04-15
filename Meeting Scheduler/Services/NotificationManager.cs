using Meeting_Scheduler.Models;

namespace Meeting_Scheduler.Services;

public class NotificationManager
{
    private readonly IServiceProvider _serviceProvider;
    private readonly List<INotificationSender> _notificationSenders;

    private NotificationManager(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _notificationSenders = serviceProvider.GetServices<INotificationSender>().ToList();
    }

    public void NotifyUsers(string content, List<User> users)
    {
        foreach (var user in users)
        {
            var notification = new Notification
            {
                Content = content,
                Recepient = user
            };
            NotifyUser(notification);
        }
    }

    private void NotifyUser(Notification notification)
    {
        foreach (var notificationSender in _notificationSenders)
        {
            notificationSender.SendNotification(notification);
        }
    }
}
