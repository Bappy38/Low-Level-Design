using Booking.com.Interfaces;
using Booking.com.Models;
using Newtonsoft.Json;

namespace Booking.com.Services;

public class ReviewService : IReviewService
{
    private const string resourcePath = @"Resources/Reviews.json";
    private static List<Review> reviews;

    static ReviewService()
    {
        var jsonData = File.ReadAllText(resourcePath);
        reviews = JsonConvert.DeserializeObject<List<Review>>(jsonData);
    }

    public void LeaveReview(int userId, int hotelId, int rating, string reviewText)
    {
        reviews.Add(new Review
        {
            Id = reviews.Count + 1,
            UserId = userId,
            HotelId = hotelId,
            Rating = rating,
            ReviewText = reviewText
        });
    }

    public List<Review> GetHotelReviews(int hotelId)
    {
        return reviews
            .Where(r => r.HotelId == hotelId)
            .OrderByDescending(r => r.Rating)
            .ToList();
    }

    public double GetAverageRating(int hotelId)
    {
        return reviews.Average(r => r.Rating);
    }
}
