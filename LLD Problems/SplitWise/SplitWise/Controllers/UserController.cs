using Microsoft.AspNetCore.Mvc;
using SplitWise.Models;
using SplitWise.Repositories;

namespace SplitWise.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var users = _userRepository.FindAll();
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(User user)
    {
        _userRepository.Create(user);
        return Created();
    }
}