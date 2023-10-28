using Parking_Lot.Features.Vehicles;

namespace Parking_Lot.Features.Parking_Spots;

public class Large : ParkingSpot
{
    public override bool AssignVehicle(Vehicle vehicle)
    {
        Vehicle = vehicle;
        return true;
    }
}
