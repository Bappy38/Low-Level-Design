namespace Composite_Pattern.Example_1;

/// <summary>
/// This is the Component we have discussed about.
/// Here, the Component consists of two fields and one methods.
/// These fields and method are going to be used as an interface between
/// the Leaf and the Composite part of our pattern
/// </summary>
public abstract class GiftBase
{
    protected string name;
    protected int price;

    public GiftBase(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

    public abstract int CalculateTotalPrice();
}
