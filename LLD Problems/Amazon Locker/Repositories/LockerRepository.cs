using Amazon_Locker.Enums;
using Amazon_Locker.Models;
using Newtonsoft.Json;

namespace Amazon_Locker.Repositories;

public interface ILockerRepository
{
    Task<Locker?> GetLockerByLocationAndSizeAsync(string locationId, LockerSize lockerSize);
}

public class LockerRepository : ILockerRepository
{
    private const string ResouceFilePath = @"Resources/Lockers.json";

    private List<Locker> _lockers = new();

    private static readonly object _lockObject = new object();

    public LockerRepository()
    {
        var jsonData = File.ReadAllText(ResouceFilePath);
        _lockers = JsonConvert.DeserializeObject<List<Locker>>(jsonData);
    }

    public async Task<Locker?> GetLockerByLocationAndSizeAsync(string locationId, LockerSize lockerSize)
    {
        Locker locker = null;

        lock (_lockObject)
        {
            locker = _lockers.FirstOrDefault(o => o.CanOccupy(locationId, lockerSize));
        }

        return locker;
    }
}
