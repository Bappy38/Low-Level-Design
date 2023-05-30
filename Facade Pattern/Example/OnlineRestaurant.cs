namespace Facade_Pattern.Example;


/// <summary>
/// This is a subsystem. The Subsystem can accepts requests either from
/// the facade or client directly. In any case, to the Subsystem, the
/// Facade is yet another client and it's not a part of the Subsystem.
/// 
/// Some Facade can works with multiple subsystems at the same time.
/// </summary>

public class OnlineRestaurant
{
    private readonly List<Order> _cart;

	public OnlineRestaurant()
	{
		_cart = new List<Order>();
	}

	public void AddOrderToCart(Order order)
	{
		_cart.Add(order);
	}

	public void CompleteOrders()
	{
		Console.WriteLine($"Orders completed. Dispatch in progress...");
	}
}
