namespace Decorator_Pattern.Example;

/// <summary>
/// This is a Concrete Decorator class. 
/// 
/// So far, implementation of our RegularOrder and PreOrder class is fine.
/// Now, suppose we need to give the premium user an additional 10 percent
/// discount for preorder. What we can do is change the PreOrder class
/// with one if statement to check if our user is a premium user, but that
/// will break Open-Closed Principle. 
/// 
/// Also, inheriting PremiumPreOrder from OrderBase is not make-senese.
/// That's why we applied decorator pattern here.
/// </summary>

public class PremiumPreOrder : OrderDecorator
{
    public PremiumPreOrder(OrderBase order) : base(order)
    {
    }

    public override decimal CalculateTotalPrice()
    {
        Console.WriteLine($"Calculating total price of premium pre-order...");

        var preOrderPrice = base.CalculateTotalPrice();

        Console.WriteLine($"Adding additional discount to pre-order price...");

        return preOrderPrice * (decimal)0.9;
    }
}
