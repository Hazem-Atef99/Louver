using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Louver.Models;

namespace Louver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnClientFileDetailsController : ControllerBase
    {
        private readonly LouverContext _context;

        public AnClientFileDetailsController(LouverContext context)
        {
            _context = context;
        }

        // GET: api/AnClientFileDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnClientFileDetail>>> GetAnClientFileDetails()
        {
          if (_context.AnClientFileDetails == null)
          {
              return NotFound();
          }
            return await _context.AnClientFileDetails.ToListAsync();
        }

        // GET: api/AnClientFileDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnClientFileDetail>> GetAnClientFileDetail(int id)
        {
          if (_context.AnClientFileDetails == null)
          {
              return NotFound();
          }
            var anClientFileDetail = await _context.AnClientFileDetails.FindAsync(id);

            if (anClientFileDetail == null)
            {
                return NotFound();
            }

            return anClientFileDetail;
        }

        // PUT: api/AnClientFileDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnClientFileDetail(int id, AnClientFileDetail anClientFileDetail)
        {
            if (id != anClientFileDetail.DetailId)
            {
                return BadRequest();
            }

            _context.Entry(anClientFileDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnClientFileDetailExists(id))
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

        // POST: api/AnClientFileDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnClientFileDetail>> PostAnClientFileDetail(AnClientFileDetail anClientFileDetail)
        {
          if (_context.AnClientFileDetails == null)
          {
              return Problem("Entity set 'LouverContext.AnClientFileDetails'  is null.");
          }
            _context.AnClientFileDetails.Add(anClientFileDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AnClientFileDetailExists(anClientFileDetail.DetailId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAnClientFileDetail", new { id = anClientFileDetail.DetailId }, anClientFileDetail);
        }

        // DELETE: api/AnClientFileDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnClientFileDetail(int id)
        {
            if (_context.AnClientFileDetails == null)
            {
                return NotFound();
            }
            var anClientFileDetail = await _context.AnClientFileDetails.FindAsync(id);
            if (anClientFileDetail == null)
            {
                return NotFound();
            }

            _context.AnClientFileDetails.Remove(anClientFileDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnClientFileDetailExists(int id)
        {
            return (_context.AnClientFileDetails?.Any(e => e.DetailId == id)).GetValueOrDefault();
        }
    }
}
