using Parking_Lot.Features.Ticket;

namespace Parking_Lot.Features.Vehicles;

public class MotorCycle : Vehicle
{
    public override void AssignTicket(ParkingTicket ticket)
    {
        Ticket = ticket;
    }
}
