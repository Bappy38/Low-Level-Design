using SplitWise.Extensions;
using SplitWise.Splits;

namespace SplitWise.ExpenseSplitValidators;

public class EqualExpenseSplitValidator : IExpenseSplitValidator
{
    public void ValidateSplitRequest(IReadOnlyList<Split> splits, double totalAmount)
    {
        var amountShouldBe = totalAmount / splits.Count;

        foreach (var split in splits)
        {
            if (!amountShouldBe.IsEqual(split.AmountOwe))
            {
                throw new Exception("Invalid Split");
            }
        }
    }
}