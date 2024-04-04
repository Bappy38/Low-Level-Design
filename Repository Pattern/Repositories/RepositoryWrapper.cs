namespace Repository_Pattern.Repositories;

public interface IRepositoryWrapper
{
    IAccountRepository Account { get; }
    Task SaveAsync();
}

public class RepositoryWrapper : IRepositoryWrapper
{
    private readonly RepositoryContext _repositoryContext;
    
    private IAccountRepository account;

    public RepositoryWrapper(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }

    public IAccountRepository Account
    {
        get
        {
            if (account is null)
            {
                account = new AccountRepository(_repositoryContext);
            }
            return account;
        }
    }

    public async Task SaveAsync()
    {
        await _repositoryContext.SaveChangesAsync();
    }
}