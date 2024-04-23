using SplitWise.Splits;

namespace SplitWise.ExpenseSplitValidators;

public interface IExpenseSplitValidator
{
    public void ValidateSplitRequest(IReadOnlyList<Split> splits, double totalAmount);
}