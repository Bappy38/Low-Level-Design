using Microsoft.AspNetCore.Mvc;
using Vending_Machine.Services;

namespace Vending_Machine.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly VendingMachine vendingMachine;

    public ClientController()
    {
        vendingMachine = VendingMachine.GetInstance();
    }

    [HttpPost("InsertMoney")]
    public async Task<IActionResult> InsertMoney([FromBody]double amount)
    {
        try
        {
            var currentState = vendingMachine.GetState();
            currentState.InsertMoney(vendingMachine, amount);
            return Ok();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    [HttpPost("SelectProduct")]
    public async Task<IActionResult> SelectProduct([FromBody]int rackNumber)
    {
        try
        {
            var currentState = vendingMachine.GetState();
            currentState.ChooseProduct(vendingMachine, rackNumber);
            return Ok();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    [HttpGet("GetChange")]
    public async Task<IActionResult> GetChange()
    {
        try
        {
            var currentState = vendingMachine.GetState();
            var changeAmount = currentState.ReturnChange(vendingMachine);
            return Ok(changeAmount);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    [HttpGet("GetFullRefund")]
    public async Task<IActionResult> GetFullRefund()
    {
        try
        {
            var currentState = vendingMachine.GetState();
            var refundAmount = currentState.RefundFullMoney(vendingMachine);
            return Ok(refundAmount);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    [HttpGet("DispenseProduct")]
    public async Task<IActionResult> DispenseProduct()
    {
        try
        {
            var currentState = vendingMachine.GetState();
            var product = currentState.DispenseProduct();
            return Ok(product);
        }
        catch (Exception)
        {

            throw;
        }
    }
}
