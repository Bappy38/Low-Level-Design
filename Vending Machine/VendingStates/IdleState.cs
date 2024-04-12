using Vending_Machine.Models;
using Vending_Machine.Services;

namespace Vending_Machine.VendingStates;

public class IdleState : IState
{
    public IdleState()
    {
        Console.WriteLine($"Currently vending machine is in IdleState");
    }

    public IdleState(VendingMachine machine)
    {
        machine.SetAmount(0);
        Console.WriteLine($"Currently vending machine is in IdleState");
    }

    public void InsertMoney(VendingMachine machine, double amount)
    {
        machine.SetState(new MoneyInsertedState(machine, amount));
    }

    public void ChooseProduct(VendingMachine machine, int rackNumber)
    {
        throw new Exception("Insert Money First");
    }

    public double ReturnChange(VendingMachine machine)
    {
        throw new Exception("Insert Money First");
    }

    public void UpdateInventory(VendingMachine machine, Product product, int rackNumber)
    {
        machine.GetInventory().AddProduct(product, rackNumber);
    }

    public Product DispenseProduct()
    {
        throw new Exception("Insert Money First");
    }

    public double RefundFullMoney(VendingMachine machine)
    {
        throw new Exception("Insert Money First");
    }
}
