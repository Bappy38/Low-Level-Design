using SplitWise.Models;

namespace SplitWise.Splits;

public abstract class Split
{
    public User User { get; set; }
    public double AmountOwe { get; set; }
}