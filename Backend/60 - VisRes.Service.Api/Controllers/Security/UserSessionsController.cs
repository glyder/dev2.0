using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisRes.Data.EFCore;
using VisRes.Models.EF;

namespace VisRes.Service.Api.Controllers.Security
{
    [Produces("application/json")]
    [Route("api/UserSessions")]
    public class UserSessionsController : Controller
    {
        private readonly VrsContext _context;

        public UserSessionsController(VrsContext context)
        {
            _context = context;
        }

        // GET: api/UserSessions
        [HttpGet]
        public IEnumerable<tblUserSessions> GettblUserSessions()
        {
            return _context.tblUserSessions;
        }

        // GET: api/UserSessions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GettblUserSessions([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblUserSessions = await _context.tblUserSessions.SingleOrDefaultAsync(m => m.UserID == id);

            if (tblUserSessions == null)
            {
                return NotFound();
            }

            return Ok(tblUserSessions);
        }

        // PUT: api/UserSessions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PuttblUserSessions([FromRoute] int id, [FromBody] tblUserSessions tblUserSessions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblUserSessions.UserID)
            {
                return BadRequest();
            }

            _context.Entry(tblUserSessions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblUserSessionsExists(id))
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

        // POST: api/UserSessions
        [HttpPost]
        public async Task<IActionResult> PosttblUserSessions([FromBody] tblUserSessions tblUserSessions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.tblUserSessions.Add(tblUserSessions);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (tblUserSessionsExists(tblUserSessions.UserID))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GettblUserSessions", new { id = tblUserSessions.UserID }, tblUserSessions);
        }

        // DELETE: api/UserSessions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletetblUserSessions([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblUserSessions = await _context.tblUserSessions.SingleOrDefaultAsync(m => m.UserID == id);
            if (tblUserSessions == null)
            {
                return NotFound();
            }

            _context.tblUserSessions.Remove(tblUserSessions);
            await _context.SaveChangesAsync();

            return Ok(tblUserSessions);
        }

        private bool tblUserSessionsExists(int id)
        {
            return _context.tblUserSessions.Any(e => e.UserID == id);
        }
    }
}