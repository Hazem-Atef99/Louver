﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Louver.Models;
using AutoMapper;
using Louver.DataModel;

namespace Louver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnCuttingListDetailsController : ControllerBase
    {
        private readonly LouverContext _context;
        private readonly IMapper _mapper;



        public AnCuttingListDetailsController(LouverContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/AnCuttingListDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnCuttingListDetailDTO>>> GetAnCuttingListDetails([FromQuery] QueryPrameters queryPrameters, int ClientFileId , int typeId)
        {
          if (_context.AnCuttingListDetails == null)
          {
              return BadRequest();
          }
          var cuttingResult= await _context.AnCuttingListDetails.Include(c => c.ClientFile).Where(c => c.ClientFile.ClientFileId == ClientFileId && c.TypeId==typeId).ToListAsync();
            var anCuttingLists = cuttingResult.Skip(queryPrameters.size * (queryPrameters.page - 1)).Take(queryPrameters.size);
            var results = _mapper.Map<IEnumerable<AnCuttingListDetailDTO>>(anCuttingLists);
            int resultsCount= cuttingResult.Count();
            return Ok(new {data=results,count = resultsCount});
        }
        [HttpGet("getColors")]
        public async Task<ActionResult> getColorlist(int clientFileId, int typeId)
        {
            if (_context.AnCuttingListDetails == null)
            {
                return BadRequest();
            }
            var cuttingResult = await _context.AnCuttingListDetails.Where(c=>c.ClientFileId==clientFileId&&c.TypeId==typeId).ToListAsync();
            List<string> colorsList=new List<string>();
            for (int i = 0; i < cuttingResult.Count; i++)
            {
                colorsList.Add(cuttingResult[i].Color1);
            }
            return Ok(colorsList);
        }


        // GET: api/AnCuttingListDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnCuttingListDetailDTO>> GetAnCuttingListDetail(int id)
        {
          if (_context.AnCuttingListDetails == null)
          {
              return BadRequest();
          }
            var anCuttingListDetail = await _context.AnCuttingListDetails.Include(c=>c.ClientFile).FirstOrDefaultAsync(c=>c.CuttingListDetailId==id);
            var result=_mapper.Map<AnCuttingListDetailDTO>(anCuttingListDetail);

            if (anCuttingListDetail == null)
            {
                return BadRequest();
            }

            return result;
        }

        // PUT: api/AnCuttingListDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnCuttingListDetail(int id, AnCuttingListDetailDTO anCuttingListDetail)
        {
            if (id != anCuttingListDetail.CuttingListDetailId)
            {
                return BadRequest();
            }
             var result =_mapper.Map<AnCuttingListDetail>(anCuttingListDetail);

            _context.Entry(result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnCuttingListDetailExists(id))
                {
                    return BadRequest();
                }
                else
                {
                    throw;
                }
            }

            return Ok(new {message="cuttingListDetail Updated Successfully", code=200});
        }

        // POST: api/AnCuttingListDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnCuttingListDetailDTO>> PostAnCuttingListDetail(AnCuttingListDetailDTO anCuttingListDetail)
        {
          if (_context.AnCuttingListDetails == null)
          {
              return Problem("Entity set 'LouverContext.AnCuttingListDetails'  is null.");

          }
          var anCuttingListDetails = _mapper.Map<AnCuttingListDetail>(anCuttingListDetail);
            _context.AnCuttingListDetails.Add(anCuttingListDetails);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AnCuttingListDetailExists(anCuttingListDetail.CuttingListDetailId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAnCuttingListDetail", new { id = anCuttingListDetail.CuttingListDetailId }, anCuttingListDetail);
        }

        // DELETE: api/AnCuttingListDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnCuttingListDetail(int id)
        {
            if (_context.AnCuttingListDetails == null)
            {
                return BadRequest();
            }
            var anCuttingListDetail = await _context.AnCuttingListDetails.FindAsync(id);
            if (anCuttingListDetail == null)
            {
                return BadRequest();
            }

            _context.AnCuttingListDetails.Remove(anCuttingListDetail);
            await _context.SaveChangesAsync();

            return Ok(new { message = "cuttingListDetail Deleted Successfully", code = 200 });
        }

        private bool AnCuttingListDetailExists(int id)
        {
            return (_context.AnCuttingListDetails?.Any(e => e.ClientFileId == id)).GetValueOrDefault();
        }
    }
}
