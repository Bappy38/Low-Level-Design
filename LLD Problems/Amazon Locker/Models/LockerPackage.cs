namespace Amazon_Locker.Models;

public class LockerPackage : Package
{
    public string LockerId { get; set; }
    public string Code { get; private set; }
    public DateTime DeliveryTimeAtUtc { get; private set; }

    public LockerPackage(string lockerId, Order order)
    {
        LockerId = lockerId;
        PackageId = Guid.NewGuid().ToString();
        Order = order;
        Code = Guid.NewGuid().ToString().Substring(1, 5);
        DeliveryTimeAtUtc = DateTime.UtcNow.AddDays(3);
    }

    public bool VerifyCode(string code)
    {
        if (DateTime.UtcNow > DeliveryTimeAtUtc.AddDays(3))
        {
            return false;
        }
        return Code == code;
    }
}
