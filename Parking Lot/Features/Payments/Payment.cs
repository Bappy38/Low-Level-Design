using Parking_Lot.Enums;

namespace Parking_Lot.Features.Payments;

public abstract class Payment
{
    private double amount;
    private PaymentStatus status;
    private DateTime timestamp;
    public abstract bool InitiateTransaction();
}
