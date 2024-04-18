using SplitWise.Enums;

namespace SplitWise.Expenses;

public class ExpenseSplitFactory
{
    public static IExpenseSplit GetSplit(ExpenseSplitType splitType)
    {
        switch (splitType)
        {
            case ExpenseSplitType.Equal:
                return new EqualExpenseSplit();
            case ExpenseSplitType.Unequal:
                return new UnequalExpenseSplit();
            case ExpenseSplitType.Percentage:
                return new PercentExpenseSplit();
            default:
                throw new Exception("Invalid Split Type");
        }
    }
}