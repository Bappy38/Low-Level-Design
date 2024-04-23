using System.ComponentModel.DataAnnotations.Schema;

namespace SplitWise.Splits;

public class Split
{
    public int Id { get; set; }
    public string Username { get; set; }
    public double AmountOwe { get; set; }
}