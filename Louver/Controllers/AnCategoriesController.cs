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
    public class AnCategoriesController : ControllerBase
    {
        private readonly Kitchen4Context _context;

        public AnCategoriesController(Kitchen4Context context)
        {
            _context = context;
        }

        // GET: api/AnCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnCategory>>> GetAnCategories()
        {
          if (_context.AnCategories == null)
          {
              return BadRequest();
          }
            return await _context.AnCategories.ToListAsync();
        }

        // GET: api/AnCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnCategory>> GetAnCategory(int id)
        {
          if (_context.AnCategories == null)
          {
              return BadRequest();
          }
            var anCategory = await _context.AnCategories.FindAsync(id);

            if (anCategory == null)
            {
                return BadRequest();
            }

            return anCategory;
        }

        // PUT: api/AnCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnCategory(int id, AnCategory anCategory)
        {
            if (id != anCategory.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(anCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnCategoryExists(id))
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

        // POST: api/AnCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnCategory>> PostAnCategory(AnCategory anCategory)
        {
          if (_context.AnCategories == null)
          {
              return Problem("Entity set 'LouverContext.AnCategories'  is null.");
          }
            _context.AnCategories.Add(anCategory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AnCategoryExists(anCategory.CategoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAnCategory", new { id = anCategory.CategoryId }, anCategory);
        }

        // DELETE: api/AnCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnCategory(int id)
        {
            if (_context.AnCategories == null)
            {
                return BadRequest();
            }
            var anCategory = await _context.AnCategories.FindAsync(id);
            if (anCategory == null)
            {
                return BadRequest();
            }

            _context.AnCategories.Remove(anCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnCategoryExists(int id)
        {
            return (_context.AnCategories?.Any(e => e.CategoryId == id)).GetValueOrDefault();
        }
    }
}
