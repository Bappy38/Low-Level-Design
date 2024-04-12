using Vending_Machine.Models;
using Vending_Machine.Services;

namespace Vending_Machine.VendingStates;

public class MoneyInsertedState : IState
{
    public MoneyInsertedState(VendingMachine machine, double amount)
    {
        Console.WriteLine($"Currently vending machine is in MoneyInsertedState");
        machine.SetAmount(amount);
    }

    public void InsertMoney(VendingMachine machine, double amount)
    {
        var amountAlreadyHave = machine.GetAmount();
        machine.SetAmount(amountAlreadyHave + amount);
    }

    public void ChooseProduct(VendingMachine machine, int rackNumber)
    {
        var existingAmount = machine.GetAmount();
        var productPrice = machine.GetInventory().GetProductPrice(rackNumber);

        if (productPrice > existingAmount)
        {
            throw new Exception("Insufficient Amount");
        }

        var remainingAmount = existingAmount - productPrice;
        machine.SetAmount(remainingAmount);

        machine.SetState(new DispenseState(machine, rackNumber));
    }

    public double ReturnChange(VendingMachine machine)
    {
        throw new Exception("Select Product to get Change");
    }

    public void UpdateInventory(VendingMachine machine, Product product, int rackNumber)
    {
        throw new Exception("Inventory cannot be updated in MoneyInsertedState");
    }

    public double RefundFullMoney(VendingMachine machine)
    {
        var amount = machine.GetAmount();
        machine.SetState(new IdleState(machine));
        return amount;
    }

    public Product DispenseProduct()
    {
        throw new Exception("Select Product First");
    }
}
