namespace Amazon_Locker.Models;

public class Order
{
    public string Id { get; set; }
    public string CustomerId { get; set; }
    public List<Item> Items { get; set; }
    public string DeliveryLocation { get; set; }
}
