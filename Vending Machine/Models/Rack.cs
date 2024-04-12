namespace Vending_Machine.Models;

public class Rack
{
    public int Id { get; set; }
    public Product? Product { get; set; }

    public bool IsEmpty()
    {
        return Product is null;
    }
}
