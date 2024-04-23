using SplitWise.Data;
using SplitWise.Models;

namespace SplitWise.Repositories;

public interface IUserRepository : IRepositoryBase<User>
{
}

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(
        RepositoryContext repositoryContext, 
        IUnitOfWork unitOfWork) 
        : 
        base(repositoryContext, unitOfWork)
    {
    }
}