namespace SplitWise.Extensions;

public static class DoubleValueCompare
{
    public static bool IsEqual(this double val1, double val2)
    {
        const double precision = 0.001;
        return Math.Abs(val1 - val2) <= precision;
    }
}