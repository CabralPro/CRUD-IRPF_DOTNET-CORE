using System.Threading.Tasks;
using CrudIrpf.Domain;

namespace CrudIrpf.Repository
{
  public interface ICrudIrpfRepository
  {
    void Add<T>(T entity) where T : class;
    void Update<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    Task<bool> SaveChangesAsync();
    Task<Irpf[]> GetAllIrpfAsync();
    Task<Irpf> GetIrpfByIdAsync(int IrpfId);
  }
}