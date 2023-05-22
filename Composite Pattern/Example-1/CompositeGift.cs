namespace Composite_Pattern.Example_1;


/// <summary>
/// This is the Composite class which can contains several Composite or 
/// Leaf objects. And it will execute it's base operation by executing
/// its childs base operation.
/// </summary>
public class CompositeGift : GiftBase, IGiftOperation
{
    private List<GiftBase> _gifts;

    public CompositeGift(string name, int price) : base(name, price)
    {
        _gifts = new List<GiftBase>();
    }

    public void Add(GiftBase gift)
    {
        _gifts.Add(gift);
    }

    public void Remove(GiftBase gift)
    {
        _gifts.Remove(gift);
    }

    public override int CalculateTotalPrice()
    {
        var totalPrice = 0;

        foreach(var gift in _gifts)
        {
            totalPrice += gift.CalculateTotalPrice();
        }

        Console.WriteLine($"Price of {name} is {totalPrice}");

        return totalPrice;
    }
}
