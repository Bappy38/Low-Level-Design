namespace Amazon_Locker.Models;

public class Package
{
    public string PackageId { get; set; }
    public double PackageSize { get; set; }
    public Order Order { get; set; }
}
