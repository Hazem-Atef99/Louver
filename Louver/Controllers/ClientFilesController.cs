using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Louver.Models;
using NuGet.Protocol;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.Data.SqlClient;
using AutoMapper;
using Louver.DataModel;

namespace Louver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientFilesController : ControllerBase   
    {
        private readonly LouverContext _context;
        private readonly MasterContext masterContext;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public ClientFilesController(LouverContext context,MasterContext context1 , IConfiguration configuration , IMapper mapper = null)
        {
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
            masterContext = context1;
        }

        // GET: api/ClientFiles
        [HttpGet]
        public async Task<IActionResult> GetClientFiles([FromQuery]QueryPrameters queryPrameters, [FromQuery] search search)
        {


            var clientFilesResult = await _context.ClientFiles.Where(c => c.StatusId == 4).Include(c => c.AnCuttingListDetails).Include(c => c.Client).Include(c => c.ClientFileProperties).ToListAsync();
             var clientFilesData= clientFilesResult.Skip(queryPrameters.size * (queryPrameters.page - 1)).Take(queryPrameters.size);
            var results = _mapper.Map<IEnumerable<clientFileDTO>>(clientFilesData);
            if (!string.IsNullOrEmpty(search.name))
            {
                results = results.Where(R => R.ClientClientName.ToLower().Contains(search.name.ToLower()));
            }
            int resultsCount=clientFilesResult.Count();
            return Ok(new {data=results,count=resultsCount, code=200});

        }

        // GET: api/ClientFiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<clientFileDTO>> GetClientFile(int id)
        {
          if (_context.ClientFiles == null)
          {
              return NotFound();
          } 
            var clientFileData = await _context.ClientFiles.Include(c => c.Client).Include(c => c.ClientFileProperties).FirstOrDefaultAsync(c => c.ClientFileId == id);
            var result =_mapper.Map<clientFileDTO>(clientFileData);
         
            if (clientFileData == null)
            {
                return NotFound();
            }

            return result;
        }
       
        // PUT: api/ClientFiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientFile(int id,[FromBody] updateClientFile clientFile)
        {
            if (id != clientFile.ClientFileID)
            {
                return BadRequest();
            }

           var clientfile= await GetById(id);
            if (clientfile == null)
                return NotFound($" No clientfile was found with this ID : {id} ");

            clientfile.TarkeebDate=clientFile.TarkeebDate;
            clientfile.Modifiedby=clientfile.Modifiedby;
            _context.Update(clientfile);
            _context.SaveChanges();

            return Ok(clientFile);
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

            var clientFile =  _context.ClientFiles.Include(c => c.AnCuttingListDetails).Include(c => c.Client).Include(c => c.ClientFileProperties).Include(c=>c.AnClientFileItems).FirstOrDefault(c=>c.ClientFileId==id);
            if (clientFile == null)
            {
                return NotFound();
            }
            var PclientFileId = new SqlParameter("@pClientFileID", System.Data.SqlDbType.Int);
            PclientFileId.Value = id;
            var Sqlstr = $"DeleteClientFile {id}";
            _context.Database.ExecuteSqlRaw(Sqlstr);
            return Ok(new {message="clientFile Deleted Successfully" , code=200});
        }

        private bool ClientFileExists(int id)
        {
            return (_context.ClientFiles?.Any(e => e.ClientFileId == id)).GetValueOrDefault();
        }
        private Task<ClientFile> GetById(int id)
        {
            return _context.ClientFiles.Include(c => c.Client).Include(c => c.ClientFileProperties).FirstOrDefaultAsync(m => m.ClientFileId == id);
        }
    }
}
