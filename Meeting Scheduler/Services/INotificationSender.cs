using Meeting_Scheduler.Models;

namespace Meeting_Scheduler.Services;

public interface INotificationSender
{
    void SendNotification(Notification notification);
}
