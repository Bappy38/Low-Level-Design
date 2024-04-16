namespace Meeting_Scheduler.Models;

public class Meeting
{
    public int Id { get; set; }
    public List<User> Participants { get; set; }
    public Interval Interval { get; set; }
    public MeetingRoom Room { get; set; }
    public string Subject { get; set; }
}
