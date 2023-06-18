using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Louver.Models;
using Louver.DataModel;
using AutoMapper;

namespace Louver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnClientFileDetailsController : ControllerBase
    {
        private readonly LouverContext _context;
        private readonly IMapper _mapper;

        public AnClientFileDetailsController(LouverContext context, IMapper mapper=null)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/AnClientFileDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnClientFileDetailDTO>>> GetAnClientFileDetails([FromQuery] QueryPrameters queryPrameters,[FromQuery]search search, int ClientFileId,int typeId)
        {
          if (_context.AnClientFileDetails == null)
          {
              return NotFound();
          }
          var clientfilesResults = await _context.AnClientFileDetails.Include(c => c.ClientFile).Where(c => c.ClientFile.ClientFileId == ClientFileId && c.Typeid==typeId).ToListAsync();
            var clientFilesDetails =clientfilesResults.Skip(queryPrameters.size * (queryPrameters.page - 1)).Take(queryPrameters.size);
            var results=_mapper.Map<IEnumerable<AnClientFileDetailDTO>>(clientFilesDetails);
            int resultscount=clientfilesResults.Count();
            return Ok(new { data=results, count=resultscount });

        }

        // GET: api/AnClientFileDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnClientFileDetailDTO>> GetAnClientFileDetail(int id)
        {
          if (_context.AnClientFileDetails == null)
          {
              return NotFound();
          }
            var anClientFileDetail = await _context.AnClientFileDetails.FindAsync(id);
            var result = _mapper.Map<AnClientFileDetailDTO>(anClientFileDetail);

            if (anClientFileDetail == null)
            {
                return NotFound();
            }

            return result;
        }

        // PUT: api/AnClientFileDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnClientFileDetail(int detaiId, int clientFileId, AnClientFileDetailDTO anClientFileDetail)
        {
            //if (detaiId != anClientFileDetail.DetailId&&clientFileId!=anClientFileDetail.ClientFileId)
            //{
            //    return BadRequest();
            //}

            _context.Entry(anClientFileDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnClientFileDetailExists(detaiId))
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
        public async Task<IActionResult> PostAnClientFileDetail(AnClientFileDetailDTO anClientFileDetail)
        {
          if (_context.AnClientFileDetails == null)
          {
              return Problem("Entity set 'LouverContext.AnClientFileDetails'  is null.");

          }
          var clientfileAdd=_mapper.Map<AnClientFileDetail>(anClientFileDetail);
            await _context.AnClientFileDetails.AddAsync(clientfileAdd);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                //if (AnClientFileDetailExists(anClientFileDetail.DetailId))
                //{
                //    return Conflict();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return Ok(clientfileAdd);
        }

        // DELETE: api/AnClientFileDetails/5
        [HttpDelete]
        public async Task<IActionResult> DeleteAnClientFileDetail(int detaiId)
        {
            if (_context.AnClientFileDetails == null)
            {
                return NotFound();
            }
            var anClientFileDetail = await _context.AnClientFileDetails.FindAsync( detaiId);
            if (anClientFileDetail == null)
            {
                return NotFound();
            }

            _context.AnClientFileDetails.Remove(anClientFileDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnClientFileDetailExists(int detaiId)
        {
            return (_context.AnClientFileDetails?.Any(e => e.DetailId == detaiId)).GetValueOrDefault();
        }
    }
}
