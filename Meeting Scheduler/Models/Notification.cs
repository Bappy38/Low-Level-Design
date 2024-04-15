namespace Meeting_Scheduler.Models;

public class Notification
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public User Recepient { get; set; }

    public Notification()
    {
        CreatedAtUtc = DateTime.UtcNow;
    }
}
