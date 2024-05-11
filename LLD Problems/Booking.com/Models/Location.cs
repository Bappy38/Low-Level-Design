namespace Booking.com.Models;

public class Location
{
    public string Name { get; set; }
    public string City { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public override bool Equals(object? obj)
    {
        var other = obj as Location;

        if (other == null) 
            return false;

        return GetDistance(other) <= 1;
    }

    public bool IsNearest(Location other, double distance)
    {
        return GetDistance(other) <= distance;
    }

    //TODO:: Calculate Distance from Latitude and Longitude
    public double GetDistance(Location other)
    {
        return 0;
    }
}
