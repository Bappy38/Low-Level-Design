using Newtonsoft.Json;
using Vending_Machine.Models;

namespace Vending_Machine.Services;

public class Inventory
{
    private const string ResouceFilePath = @"Resources/Racks.json";
    private List<Rack> racks;

    public Inventory()
    {
        racks = new List<Rack>();
        InititalizeInventorySeed();
    }

    public double GetProductPrice(int rackId)
    {
        var respectiveRack = racks.Where(rack => rack.Id == rackId).FirstOrDefault();

        if (respectiveRack is null)
        {
            throw new Exception("Invalid RackId");
        }

        if (respectiveRack.IsEmpty())
        {
            throw new Exception("Empty Rack");
        }

        return respectiveRack.Product.Price;
    }

    public bool AddProduct(Product product, int rackId)
    {
        var respectiveRack = racks.Where(rack => rack.Id == rackId).FirstOrDefault();
        if (respectiveRack is null)
        {
            throw new Exception("Invalid rackId provided");
        }

        if (!respectiveRack.IsEmpty())
        {
            throw new Exception($"Rack with id {rackId} already contains a product");
        }

        respectiveRack.Product = product;
        return true;
    }

    public Product GetProduct(int rackId)
    {
        var respectiveRack = racks.Where(rack => rack.Id == rackId).FirstOrDefault();

        if (respectiveRack is null || respectiveRack.IsEmpty())
        {
            throw new Exception("Product not found");
        }

        return respectiveRack.Product;
    }

    public bool RemoveProduct(int rackId)
    {
        var respectiveRack = racks.Where(rack => rack.Id == rackId).FirstOrDefault();
        if (respectiveRack is null)
        {
            return false;
        }
        respectiveRack.Product = null;
        return true;
    }

    private void InititalizeInventorySeed()
    {
        var jsonData = File.ReadAllText(ResouceFilePath);
        racks = JsonConvert.DeserializeObject<List<Rack>>(jsonData);
    }
}
