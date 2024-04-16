using Meeting_Scheduler.Models;
using Meeting_Scheduler.Services;
using Microsoft.AspNetCore.Mvc;

namespace Meeting_Scheduler.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MeetingController : ControllerBase
{
    private readonly IMeetingScheduler meetingScheduler;

    public MeetingController(IMeetingScheduler meetingScheduler)
    {
        this.meetingScheduler = meetingScheduler;
    }

    [HttpPost("Schedule")]
    public async Task<IActionResult> ScheduleMeeting([FromBody] List<User> users, [FromBody] Interval interval)
    {
        try
        {
            meetingScheduler.ScheduleMeeting(users, interval);
            return Created();
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return BadRequest();
        }
    }
}
