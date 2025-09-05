using System;
using CerebusBlazorUI.Classes.User;
using Microsoft.EntityFrameworkCore;

namespace CerebusBlazorUI.Utilities.Entity;

public class CerebusContext : DbContext
{
  public CerebusContext(DbContextOptions<CerebusContext> options)
    : base(options)
{ }
    public DbSet<User> Users { get; set; }

    //public DbSet<Publisher> Publisher { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("Server=localhost; User ID=bob.reed; Password=!#AdminPwd10; Database=dbo");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      Seeder.Seed(modelBuilder);
    }
}
