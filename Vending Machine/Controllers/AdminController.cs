using Microsoft.AspNetCore.Mvc;
using Vending_Machine.Models;
using Vending_Machine.Services;

namespace Vending_Machine.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly VendingMachine vendingMachine;
    public AdminController()
    {
        vendingMachine = VendingMachine.GetInstance();
    }

    [HttpPost("AddProduct")]
    public async Task<IActionResult> AddProduct([FromBody] Rack rack)
    {
        try
        {
            var currentState = vendingMachine.GetState();
            currentState.UpdateInventory(vendingMachine, rack.Product, rack.Id);
            return Ok();
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            throw;
        }
    }
}
