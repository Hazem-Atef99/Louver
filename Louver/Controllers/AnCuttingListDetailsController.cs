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
    public class AnCuttingListDetailsController : ControllerBase
    {
        private readonly LouverContext _context;

        public AnCuttingListDetailsController(LouverContext context)
        {
            _context = context;
        }

        // GET: api/AnCuttingListDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnCuttingListDetail>>> GetAnCuttingListDetails([FromQuery] QueryPrameters queryPrameters)
        {
          if (_context.AnCuttingListDetails == null)
          {
              return NotFound();
          }
            return await _context.AnCuttingListDetails.Skip(queryPrameters.size * (queryPrameters.page - 1)).Take(queryPrameters.size).ToListAsync();
        }

        // GET: api/AnCuttingListDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnCuttingListDetail>> GetAnCuttingListDetail(int id)
        {
          if (_context.AnCuttingListDetails == null)
          {
              return NotFound();
          }
            var anCuttingListDetail = await _context.AnCuttingListDetails.FindAsync(id);

            if (anCuttingListDetail == null)
            {
                return NotFound();
            }

            return anCuttingListDetail;
        }

        // PUT: api/AnCuttingListDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnCuttingListDetail(int id, AnCuttingListDetail anCuttingListDetail)
        {
            if (id != anCuttingListDetail.ClientFileId)
            {
                return BadRequest();
            }

            _context.Entry(anCuttingListDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnCuttingListDetailExists(id))
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

        // POST: api/AnCuttingListDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnCuttingListDetail>> PostAnCuttingListDetail(AnCuttingListDetail anCuttingListDetail)
        {
          if (_context.AnCuttingListDetails == null)
          {
              return Problem("Entity set 'LouverContext.AnCuttingListDetails'  is null.");
          }
            _context.AnCuttingListDetails.Add(anCuttingListDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AnCuttingListDetailExists(anCuttingListDetail.ClientFileId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAnCuttingListDetail", new { id = anCuttingListDetail.ClientFileId }, anCuttingListDetail);
        }

        // DELETE: api/AnCuttingListDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnCuttingListDetail(int id)
        {
            if (_context.AnCuttingListDetails == null)
            {
                return NotFound();
            }
            var anCuttingListDetail = await _context.AnCuttingListDetails.FindAsync(id);
            if (anCuttingListDetail == null)
            {
                return NotFound();
            }

            _context.AnCuttingListDetails.Remove(anCuttingListDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnCuttingListDetailExists(int id)
        {
            return (_context.AnCuttingListDetails?.Any(e => e.ClientFileId == id)).GetValueOrDefault();
        }
    }
}
