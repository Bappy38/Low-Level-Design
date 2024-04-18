using Microsoft.AspNetCore.Mvc;
using SplitWise.Models;

namespace SplitWise.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpenseController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Expense expense)
    {
        ;
    }
}