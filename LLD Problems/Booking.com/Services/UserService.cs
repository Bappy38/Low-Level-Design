using Booking.com.Interfaces;
using Booking.com.Models;

namespace Booking.com.Services;

public class UserService : IUserService
{
    private static List<User> users;

    static UserService()
    {
        //TODO:: Fetch users from resource.json
        users = new List<User>();
    }

    public bool Login(string email, string password)
    {
        var user = users.FirstOrDefault(u => u.Email == email);

        if (user is null)
        {
            return false;
        }

        if (user.Password.Equals(password))
        {
            return true;
        }
        return false;
    }

    public void RegisterUser(string name, string email, string password)
    {
        users.Add(new User 
        { 
            Id = users.Count + 1,
            Name = name,
            Email = email, 
            Password = password 
        });
    }
}
