namespace Meeting_Scheduler.Models;

public class MeetingRoom
{
    public int Id { get; set; }
    public int Capacity { get; set; }
    public List<Interval> BookedIntervals { get; set; }

    public bool IsAvailable(Interval interval)
    {
        return true;
    }
}
