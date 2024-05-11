namespace Booking.com.Models;

public class Review
{
    public int Id { get; set; }
    public int HotelId { get; set; }
    public int UserId { get; set; }
    public int Rating { get; set; }
    public string ReviewText { get; set; }
}
