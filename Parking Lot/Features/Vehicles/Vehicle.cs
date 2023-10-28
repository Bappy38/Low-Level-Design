using Parking_Lot.Features.Ticket;

namespace Parking_Lot.Features.Vehicles;

public abstract class Vehicle
{
    public string LicenseNo { get; private set; }
    public ParkingTicket Ticket { get; set; }

    public abstract void AssignTicket(ParkingTicket ticket);
}
