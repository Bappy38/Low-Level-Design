using Vending_Machine.Models;
using Vending_Machine.Services;

namespace Vending_Machine.VendingStates;

public interface IState
{
    void InsertMoney(VendingMachine machine, double amount);
    void ChooseProduct(VendingMachine machine, int rackNumber);
    double ReturnChange(VendingMachine machine);
    void UpdateInventory(VendingMachine machine, Product product, int rackNumber);
    Product DispenseProduct();
    double RefundFullMoney(VendingMachine machine);
}
