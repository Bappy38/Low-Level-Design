using Amazon_Locker.Enums;

namespace Amazon_Locker.Models;

public class Locker
{
    public string Id { get; set; }
    public LockerSize Size { get; set; }
    public string LocationId { get; set; }
    public LockerState State { get; set; }
    public DateTime LockedTill { get; set; } = DateTime.UtcNow;

    public bool CanOccupy(string locationId, LockerSize size)
    {
        var canOccupy = (State == LockerState.Available && locationId == LocationId && size == Size && LockedTill < DateTime.UtcNow);

        if (canOccupy)
        {
            LockedTill = DateTime.UtcNow.AddMinutes(5);
            return true;
        }
        return false;
    }

    public bool TryAddPackage()
    {
        if (State != LockerState.Available && LockedTill >= DateTime.UtcNow)
        {
            return false;
        }

        State = LockerState.Booked;
        return true;
    }

    public bool TryRemovePackage() 
    {
        if (State != LockerState.Booked)
        {
            return false;
        }

        State = LockerState.Available;
        return true;
    }
}
