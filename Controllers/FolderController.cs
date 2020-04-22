using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shipp.Data;
using shipp.Models;

namespace shipp.Controllers
{
  [ApiController]
  [Route("v1/folders")]
  public class FolderController : ControllerBase
  {
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Folder>>> Get([FromServices]MyDbContext context)
    {
      var folders = await context.Folders.Include(x => x.sheets).ToListAsync();
      return folders;
    }

    public async Task<ActionResult<Folder>> Create([FromServices] MyDbContext context, [FromBody] Folder model)
    {
      if (ModelState.IsValid)
      {
        context.Folders.Add(model);
        await context.SaveChangesAsync();
        return model;
      }
      else
      {
        return BadRequest(ModelState);
      }
    }
  }

}