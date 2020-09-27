using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudIrpf.Repository;
using CrudIrpf.Domain;

namespace CrudIrpf.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class IrpfController : ControllerBase
  {
    private readonly ICrudIrpfRepository _repo;
    public IrpfController(ICrudIrpfRepository _repo)
    {
      this._repo = _repo;
    }


    [HttpGet]
    public async Task<IActionResult> Get()
    {
      try
      {
        var result = await _repo.GetAllIrpfAsync();
        return Ok(result);
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError);
      }
    }

    [HttpPost]
    public async Task<IActionResult> Post(Irpf irpf)
    {
      try
      {
        _repo.Add(irpf);
        if (await _repo.SaveChangesAsync())
          return Created($"/irpf", irpf);
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError);
      }
      return BadRequest();
    }

    [HttpPut]
    public async Task<IActionResult> Put(Irpf irpf)
    {
      try
      {
        // var ipf = await _repo.ge
        _repo.Add(irpf);
        if (await _repo.SaveChangesAsync())
          return Created($"/irpf", irpf);
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError);
      }
      return BadRequest();
    }


  }
}
