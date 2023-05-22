namespace Decorator_Pattern.Example;

/// <summary>
/// This is a Decorator class. It holds the original behavior of the order
/// object. We will add additional behavior to the order object on top of
/// this decorator.
/// </summary>

public class OrderDecorator : OrderBase
{
    protected OrderBase order;

    public OrderDecorator(OrderBase order)
    {
        this.order = order;
    }

    public override decimal CalculateTotalPrice()
    {
        Console.WriteLine($"Calculating total price in a decorator...");

        return order.CalculateTotalPrice();
    }
}
