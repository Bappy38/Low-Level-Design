using Vending_Machine.Models;
using Vending_Machine.VendingStates;

namespace Vending_Machine.Services;

public class VendingMachine
{
    private IState currentState;
    private Inventory inventory;
    private double amount;

    private static VendingMachine instance = null;
    private static readonly object _lockObject = new object();

    private VendingMachine()
    {
        currentState = new IdleState();
        inventory = new Inventory();
        amount = 0;
    }

    public static VendingMachine GetInstance()
    {
        if (instance is null)
        {
            lock( _lockObject)
            {
                if (instance is null)
                {
                    instance = new VendingMachine();
                }
            }
        }
        return instance;
    }

    public Inventory GetInventory()
    {
        return inventory;
    }

    public IState GetState()
    {
        return currentState;
    }

    public void SetState(IState state)
    {
        currentState = state;
    }

    public double GetAmount()
    {
        return amount;
    }

    public void SetAmount(double amount)
    {
        this.amount = amount;
    }
}
