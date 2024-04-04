using Microsoft.EntityFrameworkCore;
using Repository_Pattern.Models;

namespace Repository_Pattern.Repositories;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Account>? Accounts { get; set; }
}