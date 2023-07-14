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
    public class AnClientFileItemsController : ControllerBase
    {
        private readonly LouverContext _context;

        public AnClientFileItemsController(LouverContext context)
        {
            _context = context;
        }

        // GET: api/AnClientFileItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnClientFileItem>>> GetAnClientFileItems(int typeId,int clientFileId)
        {
          if (_context.AnClientFileItems == null)
          {
              return NotFound();
          }
          var result= await _context.AnClientFileItems.Include(x => x.AnClientFileDetails).Where(x=>x.ClientFileiD==clientFileId&&x.CuttingListCategoryId==typeId).ToListAsync();
            var dataCount= result.Count();

            return Ok(new { data = result, count = dataCount, code = 200 });
        }

        // GET: api/AnClientFileItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnClientFileItem>> GetAnClientFileItem(int id)
        {
          if (_context.AnClientFileItems == null)
          {
              return NotFound();
          }
            var anClientFileItem = await _context.AnClientFileItems.FindAsync(id);

            if (anClientFileItem == null)
            {
                return NotFound();
            }

            return anClientFileItem;
        }

        // PUT: api/AnClientFileItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnClientFileItem(int id, AnClientFileItem anClientFileItem)
        {
            if (id != anClientFileItem.ClientFileitemId)
            {
                return BadRequest();
            }

            _context.Entry(anClientFileItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnClientFileItemExists(id))
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

        // POST: api/AnClientFileItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnClientFileItem>> PostAnClientFileItem(AnClientFileItem anClientFileItem)
        {
          if (_context.AnClientFileItems == null)
          {
              return Problem("Entity set 'LouverContext.AnClientFileItems'  is null.");
          }
            _context.AnClientFileItems.Add(anClientFileItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnClientFileItem", new { id = anClientFileItem.ClientFileitemId }, anClientFileItem);
        }

        // DELETE: api/AnClientFileItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnClientFileItem(int id)
        {
            if (_context.AnClientFileItems == null)
            {
                return NotFound();
            }
            var anClientFileItem = await _context.AnClientFileItems.FindAsync(id);
            if (anClientFileItem == null)
            {
                return NotFound();
            }

            _context.AnClientFileItems.Remove(anClientFileItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnClientFileItemExists(int id)
        {
            return (_context.AnClientFileItems?.Any(e => e.ClientFileitemId == id)).GetValueOrDefault();
        }
    }
}
