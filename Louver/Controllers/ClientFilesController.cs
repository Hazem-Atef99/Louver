using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Louver.Models;
using Microsoft.Data.SqlClient;
using System.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Storage;
using Louver.DataModel;
using Louver.Helpers;
using AutoMapper;
using Microsoft.CodeAnalysis;

namespace Louver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientFilesController : ControllerBase   
    {
        private readonly LouverContext _context;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public ClientFilesController(LouverContext context , IConfiguration configuration , IMapper mapper = null)
        {
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
        }

        // GET: api/ClientFiles
        [HttpGet]
        public async Task<IEnumerable<clientFileDTO>> GetClientFiles()
        {
            //var parameter = new List<SqlParameter>();
            //parameter.Add(new SqlParameter("@pFlag", 1));
            //parameter.Add(new SqlParameter("@pStatusID",4));
            //var clientFilesData= await _context.ClientFiles.FromSqlRaw<ClientFile>("exec dbo.GetClientFile @pFlag, @pStatusID ", parameter.ToArray()).ToListAsync();
            //return clientFilesData;
            var clientFilesData= await _context.ClientFiles.Where(c=>c.StatusId==4).ToListAsync();
            var results = _mapper.Map<IEnumerable<clientFileDTO>>(clientFilesData);
            return results;

        }

        // GET: api/ClientFiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientFile>> GetClientFile(int id)
        {
          if (_context.ClientFiles == null)
          {
              return NotFound();
          }
            var clientFile = await _context.ClientFiles.FindAsync(id);

            if (clientFile == null)
            {
                return NotFound();
            }

            return clientFile;
        }

        // PUT: api/ClientFiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientFile(int id, ClientFile clientFile)
        {
            if (id != clientFile.ClientFileId)
            {
                return BadRequest();
            }

            _context.Entry(clientFile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientFileExists(id))
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

        // POST: api/ClientFiles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClientFile>> PostClientFile(ClientFile clientFile)
        {
          if (_context.ClientFiles == null)
          {
              return Problem("Entity set 'LouverContext.ClientFiles'  is null.");
          }
            _context.ClientFiles.Add(clientFile);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClientFileExists(clientFile.ClientFileId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClientFile", new { id = clientFile.ClientFileId }, clientFile);
        }

        // DELETE: api/ClientFiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientFile(int id)
        {
            if (_context.ClientFiles == null)
            {
                return NotFound();
            }
            var clientFile = await _context.ClientFiles.FindAsync(id);
            if (clientFile == null)
            {
                return NotFound();
            }

            _context.ClientFiles.Remove(clientFile);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientFileExists(int id)
        {
            return (_context.ClientFiles?.Any(e => e.ClientFileId == id)).GetValueOrDefault();
        }
    }
}
