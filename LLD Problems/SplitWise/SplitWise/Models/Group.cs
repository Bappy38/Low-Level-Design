namespace SplitWise.Models;

public class Group
{
    public string Id { get; set; }
    public string Title { get; set; }
    public List<User> Members { get; set; }
    public List<Expense> Expenses { get; set; }
}