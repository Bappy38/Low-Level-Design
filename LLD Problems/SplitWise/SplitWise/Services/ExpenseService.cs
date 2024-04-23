using SplitWise.ExpenseSplitValidators;
using SplitWise.Interfaces;
using SplitWise.Models;
using SplitWise.Repositories;

namespace SplitWise.Services;

public class ExpenseService : IExpenseService
{
    private readonly IExpenseRepository _expenseRepository;

    public ExpenseService(IExpenseRepository expenseRepository)
    {
        _expenseRepository = expenseRepository;
    }

    public void Create(Expense expense)
    {
        try
        {
            var validator = ExpenseSplitValidatorFactory.GetValidator(expense.SplitType);
            validator.ValidateSplitRequest(expense.Splits, expense.Amount);
            _expenseRepository.Create(expense);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}