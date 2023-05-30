namespace Facade_Pattern.Example;

/// <summary>
/// Another subsystem
/// </summary>

public class ShippingService
{
    private Order _order;

    public void AcceptOrder(Order order)
    {
        _order = order;
    }

    public void CalculateShippingCost()
    {
        _order.ShippingCost = 15.5;
    }

    public void ShipOrder()
    {
        Console.WriteLine(_order.ToString());
        Console.WriteLine($"Order is being shipped to {_order.ShippingAddress}");
    }
}
