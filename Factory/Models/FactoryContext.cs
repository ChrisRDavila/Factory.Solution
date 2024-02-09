using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<ClassName> ClassName { get; set; }
    public DbSet<ClassName2> ClassName2 { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}