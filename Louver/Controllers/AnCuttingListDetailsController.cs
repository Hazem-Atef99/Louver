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
using Louver.DataModel;
using AutoMapper;
using DocumentFormat.OpenXml.Drawing.Charts;
using ServiceStack;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Louver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnCuttingListDetailsController : ControllerBase
    {
        private readonly Kitchen4Context _context;
        private readonly IMapper _mapper;



        public AnCuttingListDetailsController(Kitchen4Context context , IMapper mapper)
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
          var cuttingResult= await _context.AnCuttingListDetails.Include(c => c.ClientFile).Include(x=>x.GrainNavigation).Include(x=>x.Material).Include(x => x.ThicknessNavigation).Include(x => x.SizeNavigation).Where(c => c.ClientFile.ClientFileId == ClientFileId && c.TypeId==typeId).Select( x=>
                              new
                              {
                                  CuttingListDetailId=x.CuttingListDetailId,
                                  ClientFileId =x.ClientFileId,
                                  DetailId=x.DetailId,
                                  TypeId=x.TypeId,
                                  MaterialId=x.MaterialId,
                                  Thickness=x.ThicknessId,
                                  Size=x.SizeId,
                                  GrainId=x.GrainId,
                                  Color1 =x.Color1,
                                  OrderBy=x.OrderBy,
                                  CreatedBy=x.CreatedBy,
                                  CreationDate = x.CreationDate,
                                  ModifiedBy=x.ModifiedBy,
                                  ModificationDate=x.ModificationDate,
                                  MaterialName=x.Material.Description+x.Material.DefaultDesc,
                                  GrainName=x.GrainNavigation.Description+x.GrainNavigation.DefaultDesc,
                                  ThicknessName=x.ThicknessNavigation.Description+x.ThicknessNavigation.DefaultDesc,
                                  SizeName=x.SizeNavigation.Description+x.SizeNavigation.DefaultDesc,

                              }).ToListAsync();
            var anCuttingLists = cuttingResult.Skip(queryPrameters.size * (queryPrameters.page - 1)).Take(queryPrameters.size);
            //var results = _mapper.Map<IEnumerable<AnCuttingListDetailDTO>>(anCuttingLists);
         
            int resultsCount= cuttingResult.Count();
            return Ok(new {data=cuttingResult,count = resultsCount});
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
            var anCuttingListDetail = await _context.AnCuttingListDetails.Include(c => c.ClientFile).Include(x => x.GrainNavigation).Include(x => x.Material).Include(x => x.ThicknessNavigation).Include(x => x.SizeNavigation).Where(c => c.CuttingListDetailId==id).Select(x =>
                              new
                              {
                                  CuttingListDetailId = x.CuttingListDetailId,
                                  ClientFileId = x.ClientFileId,
                                  DetailId = x.DetailId,
                                  TypeId = x.TypeId,
                                  MaterialId = x.MaterialId,
                                  Thickness = x.ThicknessId,
                                  Size = x.SizeId,
                                  GrainId = x.GrainId,
                                  Color1 = x.Color1,
                                  OrderBy = x.OrderBy,
                                  CreatedBy = x.CreatedBy,
                                  CreationDate = x.CreationDate,
                                  ModifiedBy = x.ModifiedBy,
                                  ModificationDate = x.ModificationDate,
                                  MaterialName = x.Material.Description + x.Material.DefaultDesc,
                                  GrainName = x.GrainNavigation.Description + x.GrainNavigation.DefaultDesc,
                                  ThicknessName = x.ThicknessNavigation.Description + x.ThicknessNavigation.DefaultDesc,
                                  SizeName = x.SizeNavigation.Description + x.SizeNavigation.DefaultDesc,

                              }).ToListAsync();

            if (anCuttingListDetail == null)
            {
                return BadRequest();
            }

            return Ok(new { data=anCuttingListDetail,code=200});
        }

        // PUT: api/AnCuttingListDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnCuttingListDetail(int id, AnCuttingListDetail anCuttingListDetail)
        {
            if (id != anCuttingListDetail.CuttingListDetailId)
            {
                return BadRequest();
            }
             //var result =_mapper.Map<AnCuttingListDetail>(anCuttingListDetail);

            _context.Update(anCuttingListDetail);

            
                await _context.SaveChangesAsync();


           

            return Ok(new {message="cuttingListDetail Updated Successfully", code=200});
        }

        // POST: api/AnCuttingListDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnCuttingListDetailDTO>> PostAnCuttingListDetail(AnCuttingListDetail anCuttingListDetail)
        {
          if (_context.AnCuttingListDetails == null)
          {
              return Problem("Entity set 'LouverContext.AnCuttingListDetails'  is null.");

          }
            //var anCuttingListDetails = _mapper.Map<AnCuttingListDetail>(anCuttingListDetail);
            anCuttingListDetail.CreationDate = DateTime.Now;

            _context.AnCuttingListDetails.Add(anCuttingListDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
              
               
                    throw;
                
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
