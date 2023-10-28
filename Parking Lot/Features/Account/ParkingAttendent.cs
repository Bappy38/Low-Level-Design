namespace Parking_Lot.Features.Account;

public class ParkingAttendent : Account
{
    public bool ProcessTicket(string ticketNumber)
    {
        return true;
    }

    public override bool ResetPassword()
    {
        throw new NotImplementedException();
    }
}
