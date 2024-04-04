using Microsoft.AspNetCore.Mvc;
using Repository_Pattern.Models;
using Repository_Pattern.Repositories;

namespace Repository_Pattern.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IRepositoryWrapper _repository;

    public AccountController(IRepositoryWrapper repository)
    {
        _repository = repository;
    }

    [HttpGet]
    [Route("GetAllAccount")]
    public async Task<IActionResult> Get()
    {
        var accounts = _repository.Account.FindAll();

        return Ok(accounts);
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] Guid id)
    {
        var account = _repository.Account.FindByCondition(o => o.Id == id).FirstOrDefault();
        if (account == null)
        {
            return NotFound();
        }

        return Ok(account);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Account account)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _repository.Account.Create(account);
        await _repository.SaveAsync();
        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] Account account)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var existingAccount = _repository.Account.FindByCondition(o => o.Id == account.Id).FirstOrDefault();

        if (existingAccount is null)
        {
            return NotFound();
        }

        existingAccount.Modify(account);
        _repository.Account.Update(existingAccount);
        await _repository.SaveAsync();

        return Ok(account);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] Account account)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _repository.Account.Delete(account);
        await _repository.SaveAsync();

        return Ok();
    }
}