namespace Decorator_Pattern.Example;

/// <summary>
/// This is a Component class.
/// </summary>
public abstract class OrderBase
{
    protected List<Product> products = new List<Product>
    {
        new Product {Name = "Phone", Price = 100},
        new Product {Name = "Tablet", Price = 200},
        new Product {Name = "PC", Price = 400}
    };

    public abstract decimal CalculateTotalPrice();
}
