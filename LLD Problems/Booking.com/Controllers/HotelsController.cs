using Booking.com.DTOs;
using Booking.com.Interfaces;
using Booking.com.Models;
using Microsoft.AspNetCore.Mvc;

namespace Booking.com.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HotelsController : ControllerBase
{
    private readonly IHotelService hotelService;
    private readonly IReviewService reviewService;

    public HotelsController(
        IHotelService hotelService,
        IReviewService reviewService)
    {
        this.hotelService = hotelService;
        this.reviewService = reviewService;
    }

    [HttpGet]
    public async Task<IActionResult> GetHotels()
    {
        var hotels = hotelService.GetAllHotels();
        return Ok(hotels);
    }

    [HttpPost]
    public async Task<IActionResult> SearchHotels([FromBody] string query)
    {
        var hotels = hotelService.SearchHotels(query);
        return Ok(hotels);
    }

    [HttpPost("Filter")]
    public async Task<IActionResult> FilterHotels([FromBody] FilterDto filter)
    {
        var hotels = hotelService.FilterHotels(filter);
        return Ok(hotels);
    }

    [HttpGet("{hotelId}/reviews")]
    public async Task<IActionResult> GetReview(int hotelId)
    {
        var reviews = reviewService.GetHotelReviews(hotelId);
        return Ok(reviews);
    }

    [HttpPost("{hotelId}/reviews")]
    public async Task<IActionResult> PostReview(int hotelId, [FromBody] Review review)
    {
        reviewService.LeaveReview(1, hotelId, review.Rating, review.ReviewText);
        return Created();
    }
}
