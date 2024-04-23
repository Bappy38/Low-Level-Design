using SplitWise.Models;

namespace SplitWise.Repositories;

public interface IExpenseRepository
{
    void Create(Expense expense);
}

public class ExpenseRepository : IExpenseRepository
{
    private static List<Expense> expenses;

    static ExpenseRepository()
    {
        expenses = new List<Expense>();
    }

    public void Create(Expense expense)
    {
        expenses.Add(expense);
    }
}