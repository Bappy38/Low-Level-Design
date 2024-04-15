using Meeting_Scheduler.Models;

namespace Meeting_Scheduler.Services;

public interface IMeetingScheduler
{
    bool ScheduleMeeting(List<User> users, Interval interval);

    bool CancelMeeting(List<User> users, Interval interval);

    bool BookRoom(MeetingRoom room, int numberOfPersons, Interval interval);

    bool ReleaseRoom(MeetingRoom room, Interval interval);

    MeetingRoom GetAvailableRoom(int numberOfPersons, Interval interval);
}
