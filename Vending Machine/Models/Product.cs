using Vending_Machine.Enums;

namespace Vending_Machine.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public ProductType Type { get; set; }
}
