using Repository_Pattern.Models;

namespace Repository_Pattern.Repositories;

public interface IAccountRepository : IRepositoryBase<Account>
{
}

public class AccountRepository : RepositoryBase<Account>, IAccountRepository
{
    public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}