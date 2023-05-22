namespace Decorator_Pattern.Example;

/// <summary>
/// It is also a Concrete Component class. Inheriting this class from 
/// Component make-sense.
/// </summary>
public class PreOrder : OrderBase
{
    public override decimal CalculateTotalPrice()
    {
        Console.WriteLine($"Calculating total price of a preorder...");

        return products.Sum( p => p.Price ) * (decimal)0.9;
    }
}
