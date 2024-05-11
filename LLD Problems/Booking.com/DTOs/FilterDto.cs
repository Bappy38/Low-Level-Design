using Booking.com.Models;

namespace Booking.com.DTOs;

public class FilterDto
{
    public Location? Location { get; set; }
    public double MaxDistance { get; set; } = -1;
    public decimal MaxPrice { get; set; } = Decimal.MaxValue;
    public decimal MinPrice { get; set; } = Decimal.MinValue;
    public double MinRating { get; set; } = 0;
}
