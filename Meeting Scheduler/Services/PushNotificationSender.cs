using Meeting_Scheduler.Models;

namespace Meeting_Scheduler.Services;

public class PushNotificationSender : INotificationSender
{
    public void SendNotification(Notification notification)
    {
        Console.WriteLine($"Sending push notification to the user: {notification.Recepient.Email}");
    }
}
