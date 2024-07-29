
using Microsoft.EntityFrameworkCore;
using QueteCodeFirst.Models;

namespace QueteCodeFirst.Data;

public class SavingContext : DbContext
{
    public SavingContext(DbContextOptions<SavingContext> options) : base(options)
    {
    }

    public DbSet<Person> People { get; set; }
    public DbSet<SavingAccount> SavingAccounts { get; set; }
    public DbSet<SavingCalculator> SavingCalculators { get; set; }
}