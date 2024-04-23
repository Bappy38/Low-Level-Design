using System.ComponentModel.DataAnnotations.Schema;

namespace SplitWise.Models;


public class ExpenseMetadata
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Notes { get; set; }

    [ForeignKey(nameof(Expense))]
    public int ExpenseId { get; set; }
    public Expense Expense { get; set; }
}