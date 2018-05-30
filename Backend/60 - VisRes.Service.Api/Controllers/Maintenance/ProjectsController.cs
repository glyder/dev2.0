using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;

using VisRes.Business.Services;

namespace VisRes.Service.Api.Controllers.Maintenance
{
    [Produces("application/json")]
    [Route("api/maintenance/Projects")]
    public class ProjectsController : Controller
    {
        private readonly IProjectsService _projectsService;

        public ProjectsController(IProjectsService projectsService)
        {
            _projectsService = projectsService;
        }

        #region "ALL"

        // GET: api/Projects
        [HttpGet]
        //[ResponseCache(Duration = 60)]
        public async Task<IEnumerable<tblProjects>> All()
        {
            return await _projectsService.GetAll();
        }

        #endregion

        #region "GetByID"

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblProjects = await _projectsService.GetByID(id);

            if (tblProjects == null)
            {
                return NotFound();
            }

            return Ok(tblProjects);
        }

        #endregion

        // api/Projects/Projects-Listbox?lobID=1
        // [HttpGet("Projects-Listbox")]
        [Route("Projects-Listbox")]
        [HttpGet]
        public IEnumerable<DropDownListViewModel> Listbox(int? lobID=null)
        {
            return _projectsService.Listbox(lobID);
        }

        #region "Put/Delete - Port Later"

        //// PUT: api/Lobs/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTblLob([FromRoute] int id, [FromBody] tblLOBs tblLob)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != tblLob.Lobid)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(tblLob).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TblLobExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Lobs
        //[HttpPost]
        //public async Task<IActionResult> PostTblLob([FromBody] tblLOBs tblLob)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.tblLOBs.Add(tblLob);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (TblLobExists(tblLob.Lobid))
        //        {
        //            return new StatusCodeResult(StatusCodes.Status409Conflict);
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetTblLob", new { id = tblLob.Lobid }, tblLob);
        //}

        //// DELETE: api/Lobs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTblLob([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var tblLob = await _context.tblLOBs.AsNoTracking().SingleOrDefaultAsync(m => m.Lobid == id);
        //    if (tblLob == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.tblLOBs.Remove(tblLob);
        //    await _context.SaveChangesAsync();

        //    return Ok(tblLob);
        //}

        //private bool TblLobExists(int id)
        //{
        //    return _context.tblLOBs.Any(e => e.Lobid == id);
        //}

        #endregion
    }
}