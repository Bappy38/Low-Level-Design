using Amazon_Locker.Enums;
using Amazon_Locker.Models;
using Amazon_Locker.Repositories;

namespace Amazon_Locker.Services;

public interface ILockerService
{
    Task<string?> OccupyLocker(string orderId, string locationId, string size);
}

public class LockerService : ILockerService
{
    private readonly ILogger<LockerService> _logger;
    private readonly ILockerRepository _lockerRepository;
    private readonly IOrderRepository _orderRepository;
    private readonly ILockerPackageRepository _lockerPackageRepository;
    private readonly INotificationRepository _notificationRepository;

    public LockerService(
        ILogger<LockerService> logger,
        ILockerRepository lockerRepository, 
        IOrderRepository orderRepository, 
        ILockerPackageRepository lockerPackageRepository,
        INotificationRepository notificationRepository
        )
    {
        _logger = logger;
        _lockerRepository = lockerRepository;
        _orderRepository = orderRepository;
        _lockerPackageRepository = lockerPackageRepository;
        _notificationRepository = notificationRepository;
    }

    public async Task<string?> OccupyLocker(string orderId, string locationId, string size)
    {
        try
        {
            var lockerSize = GetLockerSize(size);

            var locker = await _lockerRepository.GetLockerByLocationAndSizeAsync(locationId, lockerSize);

            if (locker?.TryAddPackage() != true)
            {
                return string.Empty;
            }

            var order = await _orderRepository.GetOrderByIdAsync(orderId);

            var lockerPackage = await _lockerPackageRepository.CreateLockerPackageAsync(locker.Id, order);

            var notification = new Notification
            {
                CustomerId = order.CustomerId,
                OrderId = orderId,
                LockerId = locker.Id,
                Code = lockerPackage.Code
            };

            await _notificationRepository.AddNotificationAsync(notification);

            _logger.LogInformation($"Locker with id {locker.Id} occupied successfully.");

            return locker.Id;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error occurred while trying to occupy locker for orderId {orderId}");
            _logger.LogError($"{ex.Message}");
            throw;
        }
    }

    private LockerSize GetLockerSize(string size)
    {
        LockerSize lockerSize;

        if (Enum.TryParse(size, out lockerSize))
        {
            return lockerSize;
        }

        throw new Exception("Invalid Size");
    }
}
