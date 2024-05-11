using Booking.com.Models;

namespace Booking.com.Interfaces;

public interface IReviewService
{
    void LeaveReview(int userId, int hotelId, int rating, string reviewText);
    List<Review> GetHotelReviews(int hotelId);
    double GetAverageRating(int hotelId);
}
