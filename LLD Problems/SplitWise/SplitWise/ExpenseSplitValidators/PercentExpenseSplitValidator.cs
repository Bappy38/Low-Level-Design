using SplitWise.Extensions;
using SplitWise.Splits;

namespace SplitWise.ExpenseSplitValidators;

public class PercentExpenseSplitValidator : IExpenseSplitValidator
{
    public void ValidateSplitRequest(IReadOnlyList<Split> splits, double totalAmount)
    {
        var totalAmountOwe = 0.0;

        foreach (var split in splits)
        {
            totalAmountOwe += split.AmountOwe;

            if (split is not PercentSplit percentSplit)
            {
                throw new Exception("Invalid Split");
            }

            var amountShouldBe = totalAmount * percentSplit.Percent;
            if (!amountShouldBe.Equals(percentSplit.AmountOwe))
            {
                throw new Exception("Invalid Split");
            }
        }

        if (!totalAmount.IsEqual(totalAmountOwe))
        {
            throw new Exception("Invalid Split");
        }
    }
}