using Amazon_Locker.Enums;
using Amazon_Locker.Services;
using Microsoft.AspNetCore.Mvc;

namespace Amazon_Locker.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LockerController : ControllerBase
{
    private readonly ILockerService _lockerService;

    public LockerController(ILockerService lockerService)
    {
        _lockerService = lockerService;
    }

    [HttpGet]
    public async Task<IActionResult> GetLocker([FromQuery]string orderId, [FromQuery]string locationId, [FromQuery]string lockerSize)
    {
        var lockerId = await _lockerService.OccupyLocker(orderId, locationId, lockerSize);

        if (string.IsNullOrEmpty(lockerId))
        {
            return NotFound();
        }
        return Ok(lockerId);
    }
}
