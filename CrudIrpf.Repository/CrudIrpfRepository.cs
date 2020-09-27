using System.Linq;
using System.Threading.Tasks;
using CrudIrpf.Domain;
using Microsoft.EntityFrameworkCore;

namespace CrudIrpf.Repository
{
  public class CrudIrpfRepository : ICrudIrpfRepository
  {
    private readonly CrudIrpfContext _crudIrpfContext;
    public CrudIrpfRepository(CrudIrpfContext crudIrpfContext)
    {
      _crudIrpfContext = crudIrpfContext;
      _crudIrpfContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
    public void Add<T>(T entity) where T : class
    {
      _crudIrpfContext.Add(entity);
    }

    public void Update<T>(T entity) where T : class
    {
      _crudIrpfContext.Update(entity);
    }
    public void Delete<T>(T entity) where T : class
    {
      _crudIrpfContext.Remove(entity);
    }

    public async Task<bool> SaveChangesAsync()
    {
      // var entries = ChangeTracker
      //     .Entries()
      //     .Where(e => e.Entity is BaseEntity && (
      //             e.State == EntityState.Added
      //             || e.State == EntityState.Modified));

      // foreach (var entityEntry in entries)
      // {
      //     ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

      //     if (entityEntry.State == EntityState.Added)
      //     {
      //         ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
      //     }
      // }
      // return base.SaveChanges();
      
      return (await _crudIrpfContext.SaveChangesAsync()) > 0;
    }
    public async Task<Irpf[]> GetAllIrpfAsync()
    {
      IQueryable<Irpf> query = _crudIrpfContext.Irpfs;
      // query = query.OrderByDescending(e => e.DtCadastro);
      return await query.ToArrayAsync();
    }
    public async Task<Irpf> GetIrpfByIdAsync(int IrpfId)
    {
      IQueryable<Irpf> query = _crudIrpfContext.Irpfs;
      query = query.Where(e => e.Id == IrpfId);
      return await query.FirstOrDefaultAsync();
    }
  }
}