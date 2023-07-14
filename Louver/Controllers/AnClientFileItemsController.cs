using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Louver.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc.Diagnostics;

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
        public async Task<ActionResult<IEnumerable<AnClientFileItem>>> GetAnClientFileItems()
        {
          if (_context.AnClientFileItems == null)
          {
              return NotFound();
          }
           
            var result= await _context.AnClientFileItems.Include(x => x.AnClientFileDetails).ToListAsync();
            var dataCount= result.Count();
            for (int i = 0; i < dataCount; i++)
            {
                var unitId = result[i].UnitId;
                var units = await _context.Statuses.Where(u => u.StatusCategoryId == 2 && u.StatusId == unitId).Select(
                cF => new {
                    statusId = cF.StatusId,
                    name = cF.Description + cF.DefaultDesc
                    
                }
                ).ToListAsync();
               


            }
            
            var status = await _context.Statuses.Where(s => s.StatusCategoryId == 89).Select(
                cF => new {
                    statusId = cF.StatusId,
                    name = cF.Description + cF.DefaultDesc
                }
                ).ToListAsync();
            var material = await _context.Statuses.Where(s => s.StatusCategoryId == 18).Select(
                cF => new {
                    statusId = cF.StatusId,
                    name = cF.Description + cF.DefaultDesc
                }
                ).ToListAsync();
            var ResultData = new
            {
                data=result,

            };

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
            var anClientFileItem = _context.AnClientFileItems.Include(A => A.AnClientFileDetails).FirstOrDefault(A=>A.ClientFileitemId==id);

            if (anClientFileItem == null)
            {
                return NotFound();
            }

            return Ok(new { data = anClientFileItem, count = 1, code = 200 });
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
