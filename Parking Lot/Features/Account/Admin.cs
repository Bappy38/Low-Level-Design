using Parking_Lot.Features.Display_Board;
using Parking_Lot.Features.Entrance_and_Exit;
using Parking_Lot.Features.Parking_Spots;

namespace Parking_Lot.Features.Account;

public class Admin : Account
{
    public bool AddParkingSpot(ParkingSpot spot)
    {
        //Implementation
        return true;
    }

    public bool AddDisplayBoard(DisplayBoard board)
    {
        return true;
    }

    public bool AddEntrance(Entrance entrance)
    {
        return true;
    }

    public bool AddExit(Exit exit)
    {
        return true;
    }

    public override bool ResetPassword()
    {
        throw new NotImplementedException();
    }
}
