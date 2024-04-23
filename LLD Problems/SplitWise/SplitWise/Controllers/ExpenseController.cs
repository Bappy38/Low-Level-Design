using Microsoft.AspNetCore.Mvc;
using SplitWise.Repositories;

namespace SplitWise.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpenseController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public ExpenseController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("GetUsers")]
    public async Task<IActionResult> GetUsers()
    {
        var users = _userRepository.FindAll();
        return Ok(users);
    }
}