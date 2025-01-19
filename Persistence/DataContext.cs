using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Character>? Characters { get; set; }
    public DbSet<Stats>? Stats { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Character>()
            .HasOne(c => c.BaseStats)
            .WithOne()
            .HasForeignKey<Character>(c => c.BaseStatsId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Character>()
            .HasOne(c => c.CurrentStats)
            .WithOne()
            .HasForeignKey<Character>(c => c.CurrentStatsId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}