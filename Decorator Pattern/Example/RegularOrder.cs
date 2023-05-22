namespace Decorator_Pattern.Example;

/// <summary>
/// It is a Concrete Component class. Inheriting this class from Component
/// make-sense.
/// </summary>
public class RegularOrder : OrderBase
{
    public override decimal CalculateTotalPrice()
    {
        Console.WriteLine($"Calculating total price of a regular order...");

        return products.Sum(product => product.Price);
    }
}
