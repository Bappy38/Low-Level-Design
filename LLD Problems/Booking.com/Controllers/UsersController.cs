using Booking.com.Interfaces;
using Booking.com.Models;
using Microsoft.AspNetCore.Mvc;

namespace Booking.com.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromBody]User user)
    {
        _userService.RegisterUser(user.Name, user.Email, user.Password);
        return Created();
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromBody]User user)
    {
        var isAuthenticated = _userService.Login(user.Email, user.Password);
        if (isAuthenticated)
        {
            //TODO:: Return a Bearer Token
            return Ok();
        }
        return BadRequest();
    }
}
