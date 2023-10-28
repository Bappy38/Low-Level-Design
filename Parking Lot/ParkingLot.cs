using Parking_Lot.Features.Entrance_and_Exit;
using Parking_Lot.Features.Parking_Spots;
using Parking_Lot.Features.Ticket;
using Parking_Lot.Features.Vehicles;
using Parking_Lot.Models;

namespace Parking_Lot;

public sealed class ParkingLot
{
    private int id;
    private string name;
    private Address address;
    private ParkingRate parkingRate;

    private Dictionary<string, Entrance> entrancesById;
    private Dictionary<string, Exit> exitsById;

    private Dictionary<string, ParkingTicket> ticketsById;

    //Singleton ParkingLot Object
    private static ParkingLot parkingLot = null;
    private static readonly object _lock = new object();

    private ParkingLot() 
    {
        //Call the name, address, parkingRate elements of the customer in the parking lot from DB
        //Create initial entrance and exit hashmaps respectively
    }

    public static ParkingLot GetInstance()
    {
        if (parkingLot == null)
        {
            lock(_lock)
            {
                if (parkingLot == null)
                {
                    parkingLot = new ParkingLot();
                }
            }
        }
        return parkingLot;
    }

    public bool AddEntrance(Entrance entrance)
    {
        return true;
    }

    public bool AddExit(Exit exit) 
    { 
        return true; 
    }

    public ParkingTicket GetParkingTicket(Vehicle vehicle)
    {
        return new();
    }

    public bool IsFull(ParkingSpot type)
    {
        return false;
    }
}
