namespace Composite_Pattern.Example_1;

/// <summary>
/// It is the Leaf class. It cannot contain any child.
/// </summary>
public class SingleGift : GiftBase
{
    public SingleGift(string name, int price) : base(name, price)
    {
    }
    public override int CalculateTotalPrice()
    {
        Console.WriteLine($"Price of {name} is {price}");
        return price;
    }
}
