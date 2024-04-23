using SplitWise.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplitWise.Splits;

public abstract class Split
{
    [Column("SplitId")]
    public int Id { get; set; }
    public int UserId { get; set; }
    public double AmountOwe { get; set; }

    [ForeignKey(nameof(Expense))]
    public int ExpenseId { get; set; }
    public Expense Expense { get; set; }
}