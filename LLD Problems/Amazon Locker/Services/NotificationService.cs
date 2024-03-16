
using Amazon_Locker.Models;
using Amazon_Locker.Repositories;

namespace Amazon_Locker.Services;

public class NotificationService : BackgroundService
{
    private readonly ILogger<NotificationService> _logger;
    private readonly INotificationRepository _notificationRepository;

    public NotificationService(
        ILogger<NotificationService> logger,
        INotificationRepository notificationRepository
        )
    {
        this._logger = logger;
        _notificationRepository = notificationRepository;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while(!stoppingToken.IsCancellationRequested)
        {
            var notifications = await _notificationRepository.GetUnprocessedNotificationsAsync();

            await ProcessNotificationsAsync(notifications);

            await Task.Delay(5000);
        }
    }

    private async Task ProcessNotificationsAsync(List<Notification> notifications)
    {
        if (!notifications.Any())
        {
            _logger.LogInformation($"No notification found to process.");
            return;
        }

        foreach (var notification in notifications)
        {
            if (notification.Process())
            {
                _logger.LogInformation($"Notification with id {notification.Id} processed successfully.");
                continue;
            }

            _logger.LogInformation($"Failed to process notification with id {notification.Id}");
        }
    }
}
