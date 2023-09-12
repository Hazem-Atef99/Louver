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
    public class AnCuttingListCatgeoriesController : ControllerBase
    {
        private readonly LouverContext _context;

        public AnCuttingListCatgeoriesController(LouverContext context)
        {
            _context = context;
        }

        // GET: api/AnCuttingListCatgeories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnCuttingListCatgeory>>> GetAnCuttingListCatgeories()
        {
          if (_context.AnCuttingListCatgeories == null)
          {
              return BadRequest();
          }
            return await _context.AnCuttingListCatgeories.ToListAsync();
        }

        // GET: api/AnCuttingListCatgeories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnCuttingListCatgeory>> GetAnCuttingListCatgeory(int id)
        {
          if (_context.AnCuttingListCatgeories == null)
          {
              return BadRequest();
          }
            var anCuttingListCatgeory = await _context.AnCuttingListCatgeories.FindAsync(id);

            if (anCuttingListCatgeory == null)
            {
                return BadRequest();
            }

            return anCuttingListCatgeory;
        }

        // PUT: api/AnCuttingListCatgeories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnCuttingListCatgeory(int id, AnCuttingListCatgeory anCuttingListCatgeory)
        {
            if (id != anCuttingListCatgeory.CuttingListCatgeoryId)
            {
                return BadRequest();
            }

            _context.Entry(anCuttingListCatgeory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnCuttingListCatgeoryExists(id))
                {
                    return BadRequest();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AnCuttingListCatgeories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnCuttingListCatgeory>> PostAnCuttingListCatgeory(AnCuttingListCatgeory anCuttingListCatgeory)
        {
          if (_context.AnCuttingListCatgeories == null)
          {
              return Problem("Entity set 'LouverContext.AnCuttingListCatgeories'  is null.");
          }
            _context.AnCuttingListCatgeories.Add(anCuttingListCatgeory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AnCuttingListCatgeoryExists(anCuttingListCatgeory.CuttingListCatgeoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAnCuttingListCatgeory", new { id = anCuttingListCatgeory.CuttingListCatgeoryId }, anCuttingListCatgeory);
        }

        // DELETE: api/AnCuttingListCatgeories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnCuttingListCatgeory(int id)
        {
            if (_context.AnCuttingListCatgeories == null)
            {
                return BadRequest();
            }
            var anCuttingListCatgeory = await _context.AnCuttingListCatgeories.FindAsync(id);
            if (anCuttingListCatgeory == null)
            {
                return BadRequest();
            }

            _context.AnCuttingListCatgeories.Remove(anCuttingListCatgeory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnCuttingListCatgeoryExists(int id)
        {
            return (_context.AnCuttingListCatgeories?.Any(e => e.CuttingListCatgeoryId == id)).GetValueOrDefault();
        }
    }
}
