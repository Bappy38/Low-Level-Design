using Amazon_Locker.Models;
using Newtonsoft.Json;

namespace Amazon_Locker.Repositories;

public interface ILockerLocationRepository
{
}

public class LockerLocationRepository
{
    private const string ResouceFilePath = @"Resources/LockerLocation.json";

    private List<LockerLocation> _lockerLocations = new();

    public LockerLocationRepository()
    {
        var jsonData = File.ReadAllText(ResouceFilePath);
        _lockerLocations = JsonConvert.DeserializeObject<List<LockerLocation>>(jsonData);
    }
}
