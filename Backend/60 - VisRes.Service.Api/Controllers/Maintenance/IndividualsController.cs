using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;

using VisRes.Business.Services;
using Microsoft.EntityFrameworkCore;

namespace VisRes.Service.Api.Controllers.Maintenance
{
    [Produces("application/json")]
    [Route("api/maintenance/Individuals")]
    public class IndividualsController : Controller
    {
        private readonly IIndividualsService _IndividualsService;

        public IndividualsController(IIndividualsService IndividualsService)
        {
            _IndividualsService = IndividualsService;
        }

        #region "ALL"

        // GET: api/Individuals
        [HttpGet]
        //[ResponseCache(Duration = 60)]
        public async Task<IEnumerable<tblIndividuals>> All()
        {
            return await _IndividualsService.GetAll();
            // return await _context.tblIndividuals.AsNoTracking().ToListAsync();
        }

        // GET: api/Individuals
        [HttpGet]
        [Route("AllPaged")]
        //[ResponseCache(Duration = 60)]
        public async Task<IPagedList<tblIndividuals>> AllPaged(int pageIndex = 0, int pageSize = 100)
        {
            return await _IndividualsService.GetAllPaged(pageIndex, pageSize);
            // return await _context.tblIndividuals.AsNoTracking().ToListAsync();
        }

        [HttpGet]
        [Route("SP")]
        public async Task<IEnumerable<tblIndividuals>> All_SP()
        {
            return await _IndividualsService.GetAll_SP();
        }

        #endregion

        #region "GetByID"

        // GET: api/Individuals/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblLob = await _IndividualsService.GetByID(id);

            if (tblLob == null)
            {
                return NotFound();
            }

            return Ok(tblLob);
        }

        #endregion

        [Route("Individuals-Listbox")]
        [HttpGet]
        public IEnumerable<DropDownListViewModel> Listbox(int? lobID = null,
                                                          int? projectID = null,
                                                          int? companyID = null)
        {
            return _IndividualsService.Listbox(lobID, projectID, companyID);
        }

        #region "Put/Delete - Port Later"

        //// PUT: api/Individuals/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTblLob([FromRoute] int id, [FromBody] tblIndividuals tblLob)
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

        //// POST: api/Individuals
        //[HttpPost]
        //public async Task<IActionResult> PostTblLob([FromBody] tblIndividuals tblLob)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.tblIndividuals.Add(tblLob);
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

        //// DELETE: api/Individuals/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTblLob([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var tblLob = await _context.tblIndividuals.AsNoTracking().SingleOrDefaultAsync(m => m.Lobid == id);
        //    if (tblLob == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.tblIndividuals.Remove(tblLob);
        //    await _context.SaveChangesAsync();

        //    return Ok(tblLob);
        //}

        //private bool TblLobExists(int id)
        //{
        //    return _context.tblIndividuals.Any(e => e.Lobid == id);
        //}

        #endregion
    }
}