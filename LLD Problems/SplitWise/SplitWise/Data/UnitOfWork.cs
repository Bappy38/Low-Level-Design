namespace SplitWise.Data;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken  cancellationToken = default);
}

public sealed class UnitOfWork : IUnitOfWork
{
    private readonly RepositoryContext _repositoryContext;

    public UnitOfWork(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _repositoryContext.SaveChangesAsync(cancellationToken);
    }
}