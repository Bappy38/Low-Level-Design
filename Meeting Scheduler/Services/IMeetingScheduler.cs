using Meeting_Scheduler.Models;

namespace Meeting_Scheduler.Services;

public interface IMeetingScheduler
{
    bool ScheduleMeeting(List<User> users, Interval interval);

    bool CancelMeeting(int meetingId);
}
