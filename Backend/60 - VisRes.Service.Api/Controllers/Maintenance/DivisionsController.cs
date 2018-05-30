using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using VisRes.Models.EF;
using VisRes.Data.EFCore;

namespace VisRes.Service.Api.Controllers.Maintenance
{
    [Produces("application/json")]
    [Route("api/maintenance/Divisions")]
    public class DivisionsController : Controller
    {
        private readonly VrsContext _context;

        public DivisionsController(VrsContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        // GET: api/Divisions
        [HttpGet]
        [ResponseCache(Duration = 60)]
        public async Task<IList<tblDivisions>> All()
        {
            return await _context.tblDivisions.AsNoTracking().ToListAsync();
                                //.Select(d => new tblDivisions() {
                                //    DivisionID = d.DivisionID,
                                //    Name = d.Name,
                                //    Description = d.Description
                                //})
        }

        // GET: api/Divisions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblDivision = await _context.tblDivisions.SingleOrDefaultAsync(m => m.DivisionID == id);

            if (tblDivision == null)
            {
                return NotFound();
            }

            return Ok(tblDivision);
        }

        // PUT: api/Divisions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblDivision([FromRoute] int id, [FromBody] tblDivisions tblDivision)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblDivision.DivisionID)
            {
                return BadRequest();
            }

            _context.Entry(tblDivision).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblDivisionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Divisions
        [HttpPost]
        public async Task<IActionResult> PostTblDivision([FromBody] tblDivisions tblDivision)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.tblDivisions.Add(tblDivision);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblDivision", new { id = tblDivision.DivisionID }, tblDivision);
        }

        // DELETE: api/Divisions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblDivision([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblDivision = await _context.tblDivisions.AsNoTracking().SingleOrDefaultAsync(m => m.DivisionID == id);
            if (tblDivision == null)
            {
                return NotFound();
            }

            _context.tblDivisions.Remove(tblDivision);
            await _context.SaveChangesAsync();

            return Ok(tblDivision);
        }

        private bool TblDivisionExists(int id)
        {
            return _context.tblDivisions.Any(e => e.DivisionID == id);
        }
    }
}