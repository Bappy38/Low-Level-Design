using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SplitWise.Data;

namespace SplitWise.Repositories;

public interface IRepositoryBase<T>
{
    IQueryable<T> FindAll();
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    Task CreateAsync(T entity, CancellationToken cancellationToken);
    Task UpdateAsync(T entity, CancellationToken cancellationToken);
    Task DeleteAsync(T entity, CancellationToken cancellationToken);
}

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected RepositoryContext RepositoryContext;
    protected IUnitOfWork UnitOfWork;

    protected RepositoryBase(
        RepositoryContext repositoryContext, 
        IUnitOfWork unitOfWork)
    {
        RepositoryContext = repositoryContext;
        UnitOfWork = unitOfWork;
    }

    public IQueryable<T> FindAll()
    {
        return RepositoryContext.Set<T>().AsNoTracking();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
    {
        return RepositoryContext.Set<T>().Where(expression).AsNoTracking();
    }

    public async Task CreateAsync(T entity, CancellationToken cancellationToken)
    {
        await RepositoryContext.Set<T>().AddAsync(entity, cancellationToken);
        await UnitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
    {
        RepositoryContext.Set<T>().Update(entity);
        await UnitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(T entity, CancellationToken cancellationToken)
    {
        RepositoryContext.Set<T>().Remove(entity);
        await UnitOfWork.SaveChangesAsync(cancellationToken);
    }
}