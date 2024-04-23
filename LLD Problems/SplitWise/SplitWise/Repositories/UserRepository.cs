using SplitWise.Data;
using SplitWise.Models;

namespace SplitWise.Repositories;

public interface IUserRepository
{
    List<User> FindAll();
    void Create(User user);
}

public class UserRepository : IUserRepository
{
    private static List<User> _users;

    static UserRepository()
    {
        _users = DataSeeder.GetSeedData<User>();
    }

    public List<User> FindAll()
    {
        return _users;
    }

    public void Create(User user)
    {
        _users.Add(user);
    }
}