using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<CLassOne> ClassOne { get; set; }
    public DbSet<ClassTwo> ClassTwo { get; set; }
    public DbSet<ClassOneClassTwo> ClassOneClassTwo { get;  set; }

    public FactoryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}