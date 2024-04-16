namespace Meeting_Scheduler.Models;

public class Interval
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public bool IsOverlapped(Interval other)
    {
        var notOverlapped = other.EndTime < StartTime || other.StartTime > EndTime;
        return !notOverlapped;
    }
}
