using SplitWise.Splits;

namespace SplitWise.Expenses;

public class UnequalExpenseSplit : IExpenseSplit
{
    public void ValidateSplitRequest(IReadOnlyList<Split> splits, double totalAmount)
    {
        var totalAmountOwe = 0.0;

        foreach (var split in splits)
        {
            totalAmount += split.AmountOwe;
        }

        if (!totalAmount.Equals(totalAmountOwe))
        {
            throw new Exception("Invalid Split");
        }
    }
}