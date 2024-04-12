using Vending_Machine.Models;
using Vending_Machine.Services;

namespace Vending_Machine.VendingStates;

public class DispenseState : IState
{
    private VendingMachine machine;
    private int selectedRackNumber;

    private string thisState => this.GetType().Name;

    public DispenseState(VendingMachine machine, int rackNumber)
    {
        this.machine = machine;
        this.selectedRackNumber = rackNumber;
        Console.WriteLine($"Currently vending machine is in DispenseState");
    }

    public Product DispenseProduct()
    {
        try
        {
            if (machine.GetAmount() > 0)
            {
                throw new Exception("Take the change first!");
            }

            var product = machine.GetInventory().GetProduct(selectedRackNumber);
            machine.GetInventory().RemoveProduct(selectedRackNumber);
            machine.SetState(new IdleState(machine));
            return product;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public void InsertMoney(VendingMachine machine, double amount)
    {
        throw new Exception($"Money caanot be inserted in {thisState} state");
    }

    public void ChooseProduct(VendingMachine machine, int rackNumber)
    {
        throw new Exception($"Product cannot be selected in {thisState} state");
    }

    public double ReturnChange(VendingMachine machine)
    {
        var remainingAmount = machine.GetAmount();
        if (remainingAmount == 0)
        {
            throw new Exception("No change to return");
        }
        machine.SetAmount(0);
        return remainingAmount;
    }

    public void UpdateInventory(VendingMachine machine, Product product, int rackNumber)
    {
        throw new Exception($"Inventory cannot be updated in {thisState} state");
    }

    public double RefundFullMoney(VendingMachine machine)
    {
        throw new Exception($"Refund cannot be happened in {thisState} state");
    }
}
