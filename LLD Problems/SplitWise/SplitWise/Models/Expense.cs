﻿using System.ComponentModel.DataAnnotations.Schema;
using SplitWise.Enums;
using SplitWise.Splits;

namespace SplitWise.Models;

public class Expense
{
    [Column("ExpenseId")]
    public string Id { get; set; }
    public double Amount { get; set; }
    public User PaidBy { get; set; }
    public List<Split> Splits { get; set; }
    public ExpenseMetadata Metadata { get; set; }
    public ExpenseSplitType SplitType { get; set; }
}