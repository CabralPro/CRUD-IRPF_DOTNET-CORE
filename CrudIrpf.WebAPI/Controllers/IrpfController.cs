using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CrudIrpf.Repository;
using CrudIrpf.Domain;

namespace CrudIrpf.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class IrpfController : ControllerBase
  {
    private readonly ICrudIrpfRepository _repo;
    public IrpfController(ICrudIrpfRepository repo)
    {
      this._repo = repo;
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

    [HttpGet("{IrpfId}")]
    public async Task<IActionResult> Get(int IrpfId)
    {
      try
      {
        var result = await _repo.GetIrpfByIdAsync(IrpfId);
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
          return Created($"/irpf/{irpf.Id}", irpf);
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError);
      }
      return BadRequest();
    }

    [HttpPut]
    public async Task<IActionResult> Put(Irpf model)
    {
      try
      {
        var irpf = await _repo.GetIrpfByIdAsync(model.Id);
        if (irpf == null)
          return NotFound();

        _repo.Update(model);

        if (await _repo.SaveChangesAsync())
          return Created($"/irpf/{model.Id}", model);
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError);
      }
      return BadRequest();
    }

    [HttpDelete("{IrpfId}")]
    public async Task<IActionResult> Delete(int IrpfId)
    {
      try
      {
        var irpf = await _repo.GetIrpfByIdAsync(IrpfId);
        if (irpf == null)
          return NotFound();

        _repo.Delete(irpf);

        if (await _repo.SaveChangesAsync())
          return Ok("{}");
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError);
      }
      return BadRequest();
    }
  }
}
