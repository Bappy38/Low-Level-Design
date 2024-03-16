using Amazon_Locker.Models;

namespace Amazon_Locker.Repositories;

public interface ILockerPackageRepository
{
    Task<LockerPackage> CreateLockerPackageAsync(string lockerId, Order order);
}

public class LockerPackageRepository : ILockerPackageRepository
{
    private List<LockerPackage> _lockerPackages = new();

    public async Task<LockerPackage> CreateLockerPackageAsync(string lockerId, Order order)
    {
        var lockerPackage = new LockerPackage(lockerId, order);
        _lockerPackages.Add(lockerPackage);
        return lockerPackage;
    }
}
