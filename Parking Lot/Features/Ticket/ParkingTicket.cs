using Parking_Lot.Features.Entrance_and_Exit;
using Parking_Lot.Features.Payments;
using Parking_Lot.Features.Vehicles;

namespace Parking_Lot.Features.Ticket;

public class ParkingTicket
{
    private int ticketNo;
    private DateTime entranceTime;
    private DateTime exitTime;
    private double amount;
    private bool status;

    private Vehicle vehicle;
    private Payment payment;
    private Entrance entrance;
    private Exit exit;
}
