using Amazon_Locker.Models;

namespace Amazon_Locker.Repositories;


public interface INotificationRepository
{
    Task AddNotificationAsync(Notification notification);
    Task<List<Notification>> GetUnprocessedNotificationsAsync();
}

public class NotificationRepository : INotificationRepository
{
    private List<Notification> _notifications;

    public NotificationRepository()
    {
        _notifications = new List<Notification>();
    }

    public async Task AddNotificationAsync(Notification notification)
    {
        _notifications.Add(notification);
    }

    public async Task<List<Notification>> GetUnprocessedNotificationsAsync()
    {
        return _notifications
            .Where(notification => notification.IsProcessed == false)
            .Take(10)
            .ToList();
    }
}
