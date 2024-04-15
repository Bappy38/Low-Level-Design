using Meeting_Scheduler.Models;

namespace Meeting_Scheduler.Services;

public class EmailNotificationSender : INotificationSender
{
    public void SendNotification(Notification notification)
    {
        Console.WriteLine($"Sending email notification to the user: {notification.Recepient.Email}");
    }
}
