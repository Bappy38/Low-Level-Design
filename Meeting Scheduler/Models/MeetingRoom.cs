namespace Meeting_Scheduler.Models;

public class MeetingRoom
{
    public int Id { get; set; }
    public int Capacity { get; set; }
    public List<Interval> BookedIntervals { get; set; }

    public bool IsAvailable(Interval interval)
    {
        return BookedIntervals.All(bookedInterval => !bookedInterval.IsOverlapped(interval));
    }

    public bool BookRoom(Interval interval)
    {
        BookedIntervals.Add(interval);
        return true;
    }

    public bool ReleaseRoom(Interval interval)
    {
        BookedIntervals.Remove(interval);
        return true;
    }
}
