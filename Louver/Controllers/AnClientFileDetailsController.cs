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
        public async Task<ActionResult<IEnumerable<AnClientFileDetail>>> GetAnClientFileDetails([FromQuery] QueryPrameters queryPrameters,[FromQuery]search search)
        {
          if (_context.AnClientFileDetails == null)
          {
              return NotFound();
          }
            var results = await _context.AnClientFileDetails.Skip(queryPrameters.size * (queryPrameters.page - 1)).Take(queryPrameters.size).ToListAsync();
            
            int resultscount=results.Count();
            return Ok(new { data=results, count=resultscount });

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
        public async Task<IActionResult> PutAnClientFileDetail(int detaiId, int clientFileId, AnClientFileDetail anClientFileDetail)
        {
            if (detaiId != anClientFileDetail.DetailId&&clientFileId!=anClientFileDetail.ClientFileId)
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
                if (!AnClientFileDetailExists(detaiId, clientFileId))
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
                if (AnClientFileDetailExists(anClientFileDetail.DetailId,anClientFileDetail.ClientFileId))
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
        [HttpDelete]
        public async Task<IActionResult> DeleteAnClientFileDetail(int detaiId, int clientFileId)
        {
            if (_context.AnClientFileDetails == null)
            {
                return NotFound();
            }
            var anClientFileDetail = await _context.AnClientFileDetails.FindAsync( detaiId,clientFileId);
            if (anClientFileDetail == null)
            {
                return NotFound();
            }

            _context.AnClientFileDetails.Remove(anClientFileDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnClientFileDetailExists(int detaiId,int clientFileId)
        {
            return (_context.AnClientFileDetails?.Any(e => e.DetailId == detaiId&&e.ClientFileId==clientFileId)).GetValueOrDefault();
        }
    }
}
