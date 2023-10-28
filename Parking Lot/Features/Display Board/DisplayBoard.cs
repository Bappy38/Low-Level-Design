using Parking_Lot.Features.Parking_Spots;

namespace Parking_Lot.Features.Display_Board;

public class DisplayBoard
{
    private int id;
    private List<Handicapped> handicappedSpot;
    private List<Compact> compactSpot;
    private List<Large> largeSpot;
    private List<MotorCycle> motorCycleSpot;

    public void ShowFreeSlot()
    {
        var freeHandicappedSpot = handicappedSpot.Count(spot => spot.IsFree);
        var freeCompactSpot = compactSpot.Count(spot => spot.IsFree);
        var freeLargeSpot = largeSpot.Count(spot => spot.IsFree);
        var freeMotorCycleSpot = motorCycleSpot.Count(spot => spot.IsFree);

        Console.WriteLine($"Available Handicapped Spot : {freeCompactSpot}");
        Console.WriteLine($"Available Compact Spot: {freeCompactSpot}");
        Console.WriteLine($"Available Large Spot: {freeLargeSpot}");
        Console.WriteLine($"Available Motorcycle Spot: {freeMotorCycleSpot}");
    }
}
