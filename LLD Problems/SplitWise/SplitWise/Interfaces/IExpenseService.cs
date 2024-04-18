using SplitWise.Models;

namespace SplitWise.Interfaces;

public interface IExpenseService
{
    void Create(Expense expense);
}