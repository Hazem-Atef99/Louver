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
    public class ClientFileRelatedDatesController : ControllerBase
    {
        private readonly Kitchen4Context _context;

        public ClientFileRelatedDatesController(Kitchen4Context context)
        {
            _context = context;
        }

        // GET: api/ClientFileRelatedDates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientFileRelatedDate>>> GetClientFileRelatedDates()
        {
          if (_context.ClientFileRelatedDates == null)
          {
              return NotFound(new {Message="Not Found" , Code = 404});
          }
          var Result= await _context.ClientFileRelatedDates.ToListAsync();
            return Ok(new { data = Result, code = 200 });
        }

        // GET: api/ClientFileRelatedDates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientFileRelatedDate>> GetClientFileRelatedDate(int id)
        {
          if (_context.ClientFileRelatedDates == null)
          {
                return NotFound(new { Message = "Not Found", Code = 404 });
            }
            var clientFileRelatedDate = await _context.ClientFileRelatedDates.FindAsync(id);

            if (clientFileRelatedDate == null)
            {
                return NotFound(new { Message = "Not Found", Code = 404 });
            }

            return Ok(new { data = clientFileRelatedDate, Code = 200 });
        }

        // PUT: api/ClientFileRelatedDates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientFileRelatedDate(int id, ClientFileRelatedDate clientFileRelatedDate)
        {
            if (id != clientFileRelatedDate.ClientFileId)
            {
                return BadRequest(new {Message="Couldn't Update",code=400});
            }

            _context.Entry(clientFileRelatedDate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientFileRelatedDateExists(id))
                {
                    return NotFound(new { Message = "Not Found", Code = 404 });
                }
                else
                {
                    throw;
                }
            }

            return Ok(new {Message="updated Successfully" , Code=200});
        }

        // POST: api/ClientFileRelatedDates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClientFileRelatedDate>> PostClientFileRelatedDate(ClientFileRelatedDate clientFileRelatedDate)
        {
          if (_context.ClientFileRelatedDates == null)
          {
              return Problem("Entity set 'LouverContext.ClientFileRelatedDates'  is null.");
          }
            _context.ClientFileRelatedDates.Add(clientFileRelatedDate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
              
                    throw;
                
            }

            return Ok( new { Message="Added",Code=200});
        }

        // DELETE: api/ClientFileRelatedDates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientFileRelatedDate(int id)
        {
            if (_context.ClientFileRelatedDates == null)
            {
                return NotFound(new { Message = "Not Found", Code = 404 });
            }
            var clientFileRelatedDate = await _context.ClientFileRelatedDates.FindAsync(id);
            if (clientFileRelatedDate == null)
            {
                return NotFound(new { Message = "Not Found", Code = 404 });
            }

            _context.ClientFileRelatedDates.Remove(clientFileRelatedDate);
            await _context.SaveChangesAsync();

            return Ok(new {Message="Deleted",Code=200});
        }

        private bool ClientFileRelatedDateExists(int id)
        {
            return (_context.ClientFileRelatedDates?.Any(e => e.ClientFileId == id)).GetValueOrDefault();
        }
    }
}
