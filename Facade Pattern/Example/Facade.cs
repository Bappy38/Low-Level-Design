namespace Facade_Pattern.Example;

/// <summary>
/// The Facade class provides a simple interface to the complex logic of
/// one or several subsystems. The Facade delegates the client request to
/// the appropriate objects within the subsystem. The Facade is also
/// responsible for managing their lifecycle.
/// 
/// The Facade class protect the client from the undesired complexity of 
/// the subsystems.
/// </summary>

public class Facade
{
    private readonly OnlineRestaurant restaurant;
    private readonly ShippingService shippingService;

    public Facade(OnlineRestaurant restaurant, ShippingService shippingService)
    {
        this.restaurant = restaurant;
        this.shippingService = shippingService;
    }

    public void OrderFood(List<Order> orders)
    {
        foreach(Order order in orders)
        {
            restaurant.AddOrderToCart(order);
        }

        restaurant.CompleteOrders();

        foreach(var order in orders)
        {
            shippingService.AcceptOrder(order);
            shippingService.CalculateShippingCost();
            shippingService.ShipOrder();
        }
    }
}
