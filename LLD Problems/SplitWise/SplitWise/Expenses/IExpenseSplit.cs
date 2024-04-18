using SplitWise.Splits;

namespace SplitWise.Expenses;

public interface IExpenseSplit
{
    public void ValidateSplitRequest(IReadOnlyList<Split> splits, double totalAmount);
}