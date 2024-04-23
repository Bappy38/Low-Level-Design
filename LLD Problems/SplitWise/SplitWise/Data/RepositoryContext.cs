using Microsoft.EntityFrameworkCore;
using SplitWise.Models;

namespace SplitWise.Data;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Group> Groups { get; set; }
}