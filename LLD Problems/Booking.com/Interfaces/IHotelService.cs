using Booking.com.DTOs;
using Booking.com.Models;

namespace Booking.com.Interfaces;

public interface IHotelService
{
    public List<Hotel> GetAllHotels();
    public List<Hotel> SearchHotels(string query);
    public List<Hotel> FilterHotels(FilterDto filter);
    public List<Hotel> GetNearestHotels(Location location, double distance);
}
