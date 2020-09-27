using CrudIrpf.Domain;
using Microsoft.EntityFrameworkCore;

namespace CrudIrpf.Repository
{
  public class CrudIrpfContext : DbContext
  {
    public CrudIrpfContext(DbContextOptions<CrudIrpfContext> options) : base(options) { }
    public DbSet<Irpf> Irpfs { get; set; }
  }
}