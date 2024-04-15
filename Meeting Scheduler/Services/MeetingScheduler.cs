using Meeting_Scheduler.Models;

namespace Meeting_Scheduler.Services;

public class MeetingScheduler : IMeetingScheduler
{
    public List<MeetingRoom> Rooms { get; set; }

    public MeetingScheduler()
    {
        Rooms = new List<MeetingRoom>();
    }

    public bool ScheduleMeeting(List<User> users, Interval interval)
    {
        //TODO:: Find out available meeting room and schedule meeting
        return true;
    }

    public bool CancelMeeting(List<User> users, Interval interval)
    {
        //TODO:: 
        return true;
    }

    public bool BookRoom(MeetingRoom room, int numberOfPersons, Interval interval)
    {
        //TODO::
        return true;
    }

    public bool ReleaseRoom(MeetingRoom room, Interval interval)
    {
        return true;
    }

    public MeetingRoom GetAvailableRoom(int numberOfPersons, Interval interval)
    {
        return null;
    }
}
