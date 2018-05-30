using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisRes.Business.Services;
using VisRes.Data.EFCore;
using VisRes.Models.EF;
using VisRes.Models.ViewModels;

namespace VisRes.Service.Api.Controllers.Maintenance
{
    [Produces("application/json")]
    [Route("api/maintenance/Lobs")]
    public class LobsController : Controller
    {
        private readonly ILOBsService _lobsService;

        public LobsController(ILOBsService lobsService)
        {
            _lobsService = lobsService;
        }

        #region "ALL"

        // GET: api/Lobs
        [HttpGet]
        //[ResponseCache(Duration = 60)]
        public async Task<IEnumerable<tblLOBs>> All()
        {
            return await _lobsService.GetAll();
            // return await _context.tblLOBs.AsNoTracking().ToListAsync();
        }

        [HttpGet]
        [Route("SP")]
        public async Task<IEnumerable<tblLOBs>> All_SP()
        {
            return await _lobsService.GetAll_SP();
        }

        #endregion

        #region "GetByID"

        // GET: api/Lobs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblLob = await _lobsService.GetByID(id);

            if (tblLob == null)
            {
                return NotFound();
            }

            return Ok(tblLob);
        }

        #endregion

        [Route("Lobs-Listbox")]
        [HttpGet]
        public IEnumerable<DropDownListViewModel> Listbox()
        {
            return _lobsService.Listbox();
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