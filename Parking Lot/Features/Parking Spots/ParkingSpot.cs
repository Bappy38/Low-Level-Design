using Parking_Lot.Features.Vehicles;

namespace Parking_Lot.Features.Parking_Spots;

public abstract class ParkingSpot
{
    public int Id { get; set; }
    public bool IsFree => Vehicle == null;
    public Vehicle Vehicle { get; set; }

    public abstract bool AssignVehicle(Vehicle vehicle);
    public bool RemoveVehicle()
    {
        Vehicle = null;
        return true;
    }
}
