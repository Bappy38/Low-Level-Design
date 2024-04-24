using Microsoft.AspNetCore.Mvc;
using SplitWise.Interfaces;
using SplitWise.Models;

namespace SplitWise.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpenseController : ControllerBase
{
    private readonly IExpenseService _expenseService;

    public ExpenseController(IExpenseService expenseService)
    {
        _expenseService = expenseService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Expense expense)
    {
        _expenseService.Create(expense);
        return Created();
    }

    [HttpGet]
    public async Task<IActionResult> Get(string username)
    {
        ;
    }
}