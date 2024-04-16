using Meeting_Scheduler.Models;

namespace Meeting_Scheduler.Services;

public class MeetingManager
{
    private List<MeetingRoom> Rooms { get; set; }
    private List<Meeting> Meetings { get; set; }

    public MeetingManager()
    {
        Rooms = new List<MeetingRoom>
        {
            new MeetingRoom
            {
                Id = 1,
                Capacity = 5
            },
            new MeetingRoom
            {
                Id = 2,
                Capacity = 4
            },
            new MeetingRoom
            {
                Id = 3,
                Capacity = 7
            }
        };

        Meetings = new ();
    }

    public bool ScheduleMeeting(List<User> users, Interval interval)
    {
        var availableRoom = GetAvailableRoom(users.Count, interval);

        if (availableRoom is null)
        {
            return false;
        }

        availableRoom.BookRoom(interval);

        var meeting = new Meeting
        {
            Id = Meetings.Count + 1,
            Participants = users,
            Interval = interval,
            Room = availableRoom,
            Subject = ""
        };
        Meetings.Add(meeting);

        return true;
    }

    public bool CancelMeeting(int meetingId)
    {
        var meeting = Meetings.FirstOrDefault(meeting => meeting.Id == meetingId);

        if (meeting is null)
        {
            throw new Exception($"Meeting with id {meetingId} not found");
        }

        meeting.Room.ReleaseRoom(meeting.Interval);
        Meetings.Remove(meeting);

        return true;
    }

    private MeetingRoom GetAvailableRoom(int numberOfPersons, Interval interval)
    {
        return Rooms
            .Where(room => room.Capacity >= numberOfPersons)
            .OrderBy(room => room.Capacity)
            .FirstOrDefault(room => room.IsAvailable(interval));
    }
}
