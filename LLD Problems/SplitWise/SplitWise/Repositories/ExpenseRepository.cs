using SplitWise.Data;
using SplitWise.Models;

namespace SplitWise.Repositories;

public interface IExpenseRepository
{
}

public class ExpenseRepository : RepositoryBase<Expense>, IExpenseRepository
{
    public ExpenseRepository(
        RepositoryContext repositoryContext, 
        IUnitOfWork unitOfWork) 
        : 
        base(repositoryContext, unitOfWork)
    {
    }
}