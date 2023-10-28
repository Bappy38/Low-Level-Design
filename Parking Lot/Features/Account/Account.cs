using Parking_Lot.Enums;
using Parking_Lot.Models;

namespace Parking_Lot.Features.Account;

public abstract class Account
{
    private string userName;
    private string password;
    private string email;
    private AccountStatus status;
    private Person person;

    public abstract bool ResetPassword();
}
