namespace Amazon_Locker.Models;

public class LockerLocation
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List<Locker> Lockers { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public DateTime OpenTime { get; set; }
    public DateTime CloseTime { get; set; }
}
