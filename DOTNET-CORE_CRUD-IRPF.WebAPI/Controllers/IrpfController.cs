using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _NET_CORE_CRUD_IRPF.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class IrpfController : ControllerBase
  {
    private readonly DataContext _context;
    public IrpfController(DataContext _context)
    {
      this._context = _context;
    }


    [HttpGet]
    public async Task<IActionResult> Get()
    {
      try
      {
        var result = await _context.Irpfs.ToListAsync();
        return Ok(result);
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError);
      }
    }
  }
}
