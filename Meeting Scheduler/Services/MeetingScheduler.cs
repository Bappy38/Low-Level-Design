using Meeting_Scheduler.Models;

namespace Meeting_Scheduler.Services;

public class MeetingScheduler : IMeetingScheduler
{
    private readonly NotificationManager _notificationManager;

    private readonly MeetingManager _meetingManager;

    public MeetingScheduler(
        NotificationManager notificationManager, 
        MeetingManager meetingManager)
    {
        _notificationManager = notificationManager;
        _meetingManager = meetingManager;
    }

    public bool ScheduleMeeting(List<User> users, Interval interval)
    {
        try
        {
            _meetingManager.ScheduleMeeting(users, interval);
            _notificationManager.NotifyUsers($"Scheduled Meeting", users);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public bool CancelMeeting(int meetingId)
    {
        try
        {
            return _meetingManager.CancelMeeting(meetingId);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}
