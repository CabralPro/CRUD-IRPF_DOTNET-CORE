using Microsoft.EntityFrameworkCore;

namespace _NET_CORE_CRUD_IRPF
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Irpf> Irpfs { get; set; }
  }
}