using SplitWise.Enums;

namespace SplitWise.ExpenseSplitValidators;

public class ExpenseSplitValidatorFactory
{
    public static IExpenseSplitValidator GetValidator(ExpenseSplitType splitType)
    {
        switch (splitType)
        {
            case ExpenseSplitType.Equal:
                return new EqualExpenseSplitValidator();
            case ExpenseSplitType.Unequal:
                return new UnequalExpenseSplitValidator();
            case ExpenseSplitType.Percentage:
                return new PercentExpenseSplitValidator();
            default:
                throw new Exception("Invalid Split Type");
        }
    }
}