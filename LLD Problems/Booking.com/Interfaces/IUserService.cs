using Booking.com.Models;

namespace Booking.com.Interfaces;

public interface IUserService
{
    void RegisterUser(string name, string email, string password);
    bool Login(string email, string password);
}
