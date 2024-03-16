using Amazon_Locker.Models;
using Newtonsoft.Json;

namespace Amazon_Locker.Repositories;

public interface IOrderRepository
{
    Task<Order> GetOrderByIdAsync(string orderId);
}

public class OrderRepository : IOrderRepository
{
    private const string ResouceFilePath = @"Resources/Orders.json";

    private List<Order> _orders = new();

    public OrderRepository()
    {
        var jsonData = File.ReadAllText(ResouceFilePath);
        _orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);
    }

    public async Task<Order> GetOrderByIdAsync(string orderId)
    {
        return _orders.FirstOrDefault(o => o.Id == orderId);
    }
}
