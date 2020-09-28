using System.Linq;
using System.Threading.Tasks;
using CrudIrpf.Domain;
using Microsoft.EntityFrameworkCore;

namespace CrudIrpf.Repository
{
  public class CrudIrpfRepository : ICrudIrpfRepository
  {
    private readonly CrudIrpfContext _context;
    public CrudIrpfRepository(CrudIrpfContext crudIrpfContext)
    {
      _context = crudIrpfContext;
      _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
    public void Add<T>(T entity) where T : class
    {
      _context.Add(entity);
    }

    public void Update<T>(T entity) where T : class
    {
      _context.Update(entity);
    }
    public void Delete<T>(T entity) where T : class
    {
      _context.Remove(entity);
    }

    public async Task<bool> SaveChangesAsync()
    {
      return (await _context.SaveChangesAsync()) > 0;
    }
    public async Task<Irpf[]> GetAllIrpfAsync()
    {
      IQueryable<Irpf> query = _context.Irpfs;
      return await query.ToArrayAsync();
    }
    public async Task<Irpf> GetIrpfByIdAsync(int IrpfId)
    {
      IQueryable<Irpf> query = _context.Irpfs;
      query = query.Where(e => e.Id == IrpfId);
      return await query.FirstOrDefaultAsync();
    }
  }
}