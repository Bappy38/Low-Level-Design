using Booking.com.Interfaces;
using Booking.com.Services;

namespace Booking.com.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IReviewService, ReviewService>();
        services.AddScoped<IHotelService, HotelService>();
        return services;
    }
}
