using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository_Pattern.Models;

[Table("account")]
public class Account
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Account type is required")]
    public string? AccountType { get; set; }

    public void Modify(Account modifiedAccount)
    {
        AccountType = modifiedAccount.AccountType;
    }
}