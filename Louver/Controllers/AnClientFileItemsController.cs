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
        public async Task<ActionResult<IEnumerable<AnClientFileItem>>> GetAnClientFileItems(int typeId,int clientFileId, [FromQuery] QueryPrameters queryPrameters)
        {
          if (_context.AnClientFileItems == null)
          {
              return NotFound();
          }
         
            var result= await _context.AnClientFileItems.Include(x => x.Unit).Include(x => x.GrainNavigation).Include(x => x.Material).Where(x=>x.ClientFileiD==clientFileId&&x.CuttingListCategoryId==typeId).Include(x => x.AnClientFileDetails).ToListAsync();
            var Data= result.Skip(queryPrameters.size * (queryPrameters.page - 1)).Take(queryPrameters.size);
            var dataCount= result.Count();
            Console.WriteLine(result);

            return Ok(new { data = Data, count = dataCount, code = 200 });
        }
        [HttpPost("fillTable")]
        public async Task<ActionResult> fillTableClientFileItem(int clientFileId, int createdBy)

        {
            if (createdBy<1)
            {
                return NotFound(new { message = "provide createdBy", Code=404 });
            }
            if (!ClientFileExists(clientFileId))
            {
                return NotFound(new { message="No ClientFile With This Id", code=404}) ;
            }
            var PclientFileId = new SqlParameter("@pClientFileID", System.Data.SqlDbType.Int);
            var PcreatedBy = new SqlParameter("@pCreatedBy", System.Data.SqlDbType.Int);
            PclientFileId.Value=clientFileId; PcreatedBy.Value=createdBy;
            var Sqlstr = $"AN_SaveClientFileItem {clientFileId} ,{createdBy}";
             _context.Database.ExecuteSqlRaw(Sqlstr);
           // await _context.SaveChangesAsync();
           // var result = await _context.AnClientFileItems.Include(x => x.Unit).Include(x => x.GrainNavigation).Include(x => x.Material).Where(x => x.ClientFileiD ==  clientFileId).Include(x => x.AnClientFileDetails).ToListAsync();
           // var dataCount=result.Count();
            return Ok(new { message ="data filled successfully", code = 200 });

           
        }

        // GET: api/AnClientFileItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnClientFileItem>> GetAnClientFileItem(int id)
        {
          if (_context.AnClientFileItems == null)
          {
              return NotFound();
          }
            var anClientFileItem = await _context.AnClientFileItems.Include(x => x.AnClientFileDetails).ThenInclude(c => c.Catgeory).Include(x => x.Unit).Include(x => x.GrainNavigation).Include(x => x.Material).FirstOrDefaultAsync(x=>x.ClientFileitemId==id);
      
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

            return Ok(new {message="updated successfully",code=200});
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
            var anClientFileItem = await _context.AnClientFileItems.Include(x=>x.AnClientFileDetails).FirstAsync(x=>x.ClientFileitemId== id);
            if (anClientFileItem == null)
            {
                return NotFound();
            }

            _context.AnClientFileItems.Remove(anClientFileItem);
            await _context.SaveChangesAsync();

            return Ok(new {message="deleted succesfully",code=200});
        }
        [HttpDelete("reset")]
        public async Task<ActionResult> ResetClientFileItems(int clientFileId)
        {
            var anClientFileItem = await _context.AnClientFileItems.FirstAsync(x => x.ClientFileiD == clientFileId);
            if (anClientFileItem == null)
            {
                return NotFound();
            }
            var result = await _context.AnClientFileItems.Include(x => x.Unit).Include(x => x.GrainNavigation).Include(x => x.Material).Where(x => x.ClientFileiD == clientFileId).Include(x => x.AnClientFileDetails).ToListAsync();
            _context.AnClientFileItems.RemoveRange(result);
            await _context.SaveChangesAsync();
            return Ok("deleted");
        }

        private bool AnClientFileItemExists(int id)
        {
            return (_context.AnClientFileItems?.Any(e => e.ClientFileitemId == id)).GetValueOrDefault();
        }
        private  AnCategory GetAnCategory(int? id)
        {
         
            var anCategory =  _context.AnCategories.FirstOrDefault(c=>c.CategoryId== id);

          

            return anCategory;
        }

        private bool ClientFileExists(int id)
        {
            return (_context.ClientFiles?.Any(e => e.ClientFileId == id)).GetValueOrDefault();
        }
       
    }
}
