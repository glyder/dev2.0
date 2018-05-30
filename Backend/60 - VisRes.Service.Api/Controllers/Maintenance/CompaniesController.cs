using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using VisRes.Models.EF;
using VisRes.Models.ViewModels;
using VisRes.Business.Services;

namespace VisRes.Service.Api.Controllers.Maintenance
{
    [Produces("application/json")]
    [Route("api/maintenance/Companies")]
    public class CompaniesController : Controller
    {
        private readonly ICompaniesService _CompaniesService;

        public CompaniesController(ICompaniesService CompaniesService)
        {
            _CompaniesService = CompaniesService;
        }

        #region "ALL"

        // GET: api/Companies
        [HttpGet]
        //[ResponseCache(Duration = 60)]
        public async Task<IEnumerable<tblCompanies>> All()
        {
            return await _CompaniesService.GetAll();
            // return await _context.tblCompanies.AsNoTracking().ToListAsync();
        }

        [HttpGet]
        [Route("SP")]
        public async Task<IEnumerable<tblCompanies>> All_SP()
        {
            return await _CompaniesService.GetAll_SP();
        }

        #endregion

        #region "GetByID"

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblLob = await _CompaniesService.GetByID(id);

            if (tblLob == null)
            {
                return NotFound();
            }

            return Ok(tblLob);
        }

        #endregion

        [Route("Companies-Listbox")]
        [HttpGet]
        public IEnumerable<DropDownListViewModel> Listbox(int? lobID = null,
                                                          int? projectID = null)
        {
            return _CompaniesService.Listbox(lobID, projectID);
        }

        #region "Put/Delete - Port Later"

        //// PUT: api/Companies/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTblLob([FromRoute] int id, [FromBody] tblCompanies tblLob)
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

        //// POST: api/Companies
        //[HttpPost]
        //public async Task<IActionResult> PostTblLob([FromBody] tblCompanies tblLob)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.tblCompanies.Add(tblLob);
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

        //// DELETE: api/Companies/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTblLob([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var tblLob = await _context.tblCompanies.AsNoTracking().SingleOrDefaultAsync(m => m.Lobid == id);
        //    if (tblLob == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.tblCompanies.Remove(tblLob);
        //    await _context.SaveChangesAsync();

        //    return Ok(tblLob);
        //}

        //private bool TblLobExists(int id)
        //{
        //    return _context.tblCompanies.Any(e => e.Lobid == id);
        //}

        #endregion
    }
}