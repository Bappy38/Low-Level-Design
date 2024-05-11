namespace Booking.com.Models;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Location Location { get; set; }
    public double AverageRating { get; set; }
    public decimal AccommodationPrice { get; set; }
    public decimal FoodPrice { get; set; }
    public decimal ServiceCharge { get; set; }
}
