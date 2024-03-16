using System.Diagnostics;

namespace Amazon_Locker.Models;

public class Notification
{
    public string Id { get; set; }
    public string CustomerId { get; set; }
    public string OrderId { get; set; }
    public string LockerId { get; set; }
    public string Code { get; set; }
    public bool IsProcessed { get; set; }

    public Notification()
    {
        Id = $"{CustomerId}-{OrderId}";
        IsProcessed = false;
    }

    public bool Process()
    {
        IsProcessed = true;
        return true;
    }
}
