using Booking.com.DTOs;
using Booking.com.Interfaces;
using Booking.com.Models;
using Newtonsoft.Json;

namespace Booking.com.Services;

public class HotelService : IHotelService
{
    private const string resourcePath = @"Resources/Hotels.json";
    private static List<Hotel> hotels;

    static HotelService()
    {
        var jsonData = File.ReadAllText(resourcePath);
        hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonData);
    }

    public List<Hotel> GetAllHotels()
    {
        return hotels;
    }

    public List<Hotel> SearchHotels(string query)
    {
        return hotels.Where(h => h.Name.Contains(query) || h.Description.Contains(query)).ToList();
    }

    public List<Hotel> FilterHotels(FilterDto filter)
    {
        var conditions = new List<Func<Hotel, bool>>();

        if (filter.Location is not null)
        {
            if (filter.MaxDistance == -1) 
            {
                Func<Hotel, bool> locationCondition = (h) => h.Location.Equals(filter.Location);
                conditions.Add(locationCondition);
            }
            else
            {
                Func<Hotel, bool> locationCondition = (h) => h.Location.IsNearest(filter.Location, filter.MaxDistance);
                conditions.Add(locationCondition);
            }
        }

        Func<Hotel, bool> MaxPriceCondition = (h) => h.AccommodationPrice <= filter.MaxPrice;
        conditions.Add(MaxPriceCondition);

        Func<Hotel, bool> MinPriceCondition = (h) => h.AccommodationPrice >= filter.MinPrice;
        conditions.Add(MinPriceCondition);

        Func<Hotel, bool> MinRatingCondition = (h) => h.AverageRating >= filter.MinRating;
        conditions.Add(MinRatingCondition);


        return hotels
            .Where(h => conditions.All(condition => condition(h)))
            .ToList();
    }

    public List<Hotel> GetNearestHotels(Location location, double distance)
    {
        return hotels
            .Where(h => h.Location.IsNearest(location, distance))
            .OrderBy(h => h.Location.GetDistance(location))
            .ToList();
    }
}
