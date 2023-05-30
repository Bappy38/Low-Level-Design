namespace Facade_Pattern.Example;

public class Order
{
    public string DishName { get; set; }
    public double DishPrice { get; set; }
    public string User { get; set; }
    public string ShippingAddress { get; set; }
    public double ShippingCost { get; set; }

    public override string ToString()
    {
        return $"User {User} ordered {DishName}. The full price is {DishPrice + ShippingCost}$.";
    }
}
