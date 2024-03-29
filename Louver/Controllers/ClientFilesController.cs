﻿using System;
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
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.CodeAnalysis.RulesetToEditorconfig;

namespace Louver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientFilesController : ControllerBase   
    {
        private readonly Kitchen4Context _context;
       
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public ClientFilesController(Kitchen4Context context, IConfiguration configuration , IMapper mapper = null)
        {
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
        }

        // GET: api/ClientFiles
        [HttpGet]
        public async Task<IActionResult> GetClientFiles([FromQuery]QueryPrameters queryPrameters, [FromQuery] search search)
        {


            var clientFilesResult = await _context.ClientFiles.Where(c => c.StatusId == 4).Include(c => c.AnCuttingListDetails).Include(c => c.Client).Include(c => c.ClientFileProperties).ToListAsync();
             var clientFilesData= clientFilesResult.Skip(queryPrameters.size * (queryPrameters.page - 1)).Take(queryPrameters.size);
            var results = _mapper.Map<IEnumerable<clientFileDTO>>(clientFilesData);
            int resultsCount = clientFilesResult.Count();
            if (!string.IsNullOrEmpty(search.name))
            {
                results = results.Where(R => R.ClientFileStatus?.ToLower()==search.name.ToLower());
                resultsCount = results.Count();
            }
            if (resultsCount==0)
            {
                return BadRequest(new {message="no client Files Found",code=404});
            }
            return Ok(new {data=results,count=resultsCount, code=200});

        }

        // GET: api/ClientFiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<clientFileDTO>> GetClientFile(int id)
        {
          if (_context.ClientFiles == null)
          {
              return BadRequest();
          } 
            var clientFileData = await _context.ClientFiles.Include(c => c.Client).Include(c => c.ClientFileProperties).FirstOrDefaultAsync(c => c.ClientFileId == id);
            var clientFileProberty = await _context.ClientFileProperties.ToListAsync();
            var result =_mapper.Map<clientFileDTO>(clientFileData);
         
            if (clientFileData == null)
            {
                return BadRequest();
            }

            return result;
        }
       
        // PUT: api/ClientFiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientFile(int id,[FromBody] updateClientFile clientFile,int userId)
        {
           var clientfile= await GetById(id);

            if (clientfile.FinalStatusId == 1)
            {
                return BadRequest(new { message = "you can't edit this item", code = 400 });
            }
            if (!GetUser(userId))
            {
                return BadRequest(new { message = "you are not authorized to edit this item", code = 400 });
            }
            if (id != clientFile.ClientFileID)
            {
                return BadRequest();
            }

            if (clientfile == null)
                return BadRequest($" No clientfile was found with this ID : {id} ");

            clientfile.TarkeebDate=clientFile.TarkeebDate;
            clientfile.Modifiedby=clientFile.ModifiedBy;
            clientfile.ModificationDate = DateTime.Now;
            _context.Update(clientfile);
            _context.SaveChanges();

            return Ok(new { message = "updated successfully", code = 200 });
        }
        [HttpPut("editFinalStatus")]
        public async Task<IActionResult> editFinalStatus(int id , int FinalStatusId,int userId)
        {
            var clientfile = await GetById(id);
          
            if (!GetUser(userId) )
            {
                return BadRequest(new { message = "you are not authorized to edit this item", code = 400 });
            }
            if (clientfile == null)
                return BadRequest(new {message= $" No clientfile was found with this ID : {id} " ,code=400});
            if (FinalStatusId!=0 && FinalStatusId!=1)
            {
                return BadRequest(new { message = "there is no status matches" ,code=400});
            }
            
            clientfile.FinalStatusId = FinalStatusId;
            clientfile.ModificationDate = DateTime.Now;
            _context.Update(clientfile);
            _context.SaveChanges();

            return Ok(new {message= "Now you can Update this Client File" ,code=200});
        }
        [HttpPut("editClientFileStatus")]
        public async Task<IActionResult> editClientFileStatus(int id, string status,int userId)
        {


            var clientfile = await GetById(id);

            if (clientfile.FinalStatusId == 1)
            {
                return BadRequest(new { message = "you can't edit this item", code = 400 });
            }
            if (!GetUser(userId))
            {
                return BadRequest(new { message = "you are not authorized to edit this item", code = 400 });
            }
            if (clientfile == null)
                return BadRequest($" No clientfile was found with this ID : {id} ");
     
                
            
            clientfile.ClientFileStatus = status;
            clientfile.ModificationDate = DateTime.Now;
            _context.Update(clientfile);
            _context.SaveChanges();

            return Ok(new { message= $" Client File stutus changed to {status}" ,code=200});
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
            if (clientFile.FinalStatusId==1)
            {
                return Problem("you can't edit this ClientFile");
            }
            clientFile.CreationDate= DateTime.Now;
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
        [HttpPost("copyClientFile")]
        public async Task<ActionResult> copyClientFile(int id)
        {
            if (_context.ClientFiles == null)
            {
                return BadRequest("no cleint Files exists");
            }
            if (!ClientFileExists(id))
            {
                return BadRequest($"no client file with this id {id}");
            }
            //INSERT INTO CLientFile
            //INSERT INTO ClientFileDetail
            //var sqlStr1 = $"SELECT [ClientFileID], [FileNo],[FileDate],[ActionByDate],[ActionByHour],[ClientNeed],[CreatedBy],[CreationDate],[Modifiedby] ,[ModificationDate],[ClientID],[DeviceNotes],[Attachment1],[Attachment2],[KitchenHeight] ,[Discount] ,[TarkeebDate] ,[DesignerID] ,[DesignerDate] ,[DiscountType] ,[ContractStatusID] ,[ContractDate] ,[ProjectManager] ,[Sitet] ,[Structure] ,[Remarks] ,[FileTypeID] ,[Project] ,[Owner] ,[Contractor] ,[AttentionMr] ,[ContractorTel] ,[AttentionMrTel] ,[InternalDoorModel] ,[ExternalDoorModel] ,[InternalDoorQuantity] ,[ExternalDoorQuantity] ,[Remarks2] ,[Measurmentid] ,[MeasurmentDate] ,[KitchecnModelID] ,[additionaldiscount] ,[AdditionalNotes] ,[AdditionalAmount] ,[PatternType] ,[KitchenLocation] ,[Notes] ,[SalesID] ,[DesignOrder] ,[ContractNo] ,[OfferNo] ,[TopDiscount] ,[CombinationPeriod] ,[StatusID] ,[AccessoryDiscount] ,[FactoryNotes] ,[FactoryConfirmID] ,[DesignStatusID] ,[Follow] ,[SentToFactoryDate] ,[AllPrice] ,[StartWeek] ,[StartMonth] ,[InvoiceNo] ,[InvoiceDate] ,[WindowPrefix] ,[RelatedClientFileID],[WithTax],[FinalStatusID],[clientFileStatus] from ClientFile Where ClientFIleID = {id}";
            //var sqlstr2 = $" SELECT  [DetailID] ,[TypeID] ,[CatgeoryID] ,[Width] ,[Hieght] ,[Length] ,[QTY] ,[CreatedBy] ,[CreationDate] ,[ModifiedBy] ,[ModificationDate] from AN_ClientFileDetail Where ClientFIleID = {id}";
            //List<ClientFile> clientFile = new List<ClientFile>();
             var clientFile = await _context.ClientFiles.Include(x=>x.ClientFileDetails).Include(x=>x.AnClientFileItems).FirstOrDefaultAsync(x=>x.ClientFileId==id);
            var anClientFileItem = await _context.AnClientFileItems.Include(x => x.AnClientFileDetails).ThenInclude(c => c.Catgeory).Include(x => x.Unit).Include(x => x.GrainNavigation).Include(x => x.Material).Where(x =>x.ClientFileiD==id).ToListAsync();
            int lastClientFileId = _context.ClientFiles.Max(item => item.ClientFileId);
            clientFile.ClientFileId = lastClientFileId+1;
            // var anClientFileItem = await _context.AnClientFileItems.Include(x => x.AnClientFileDetails).ThenInclude(c => c.Catgeory).Include(x => x.Unit).Include(x => x.GrainNavigation).Include(x => x.Material).FirstOrDefaultAsync(x => x.ClientFileiD == id);
            var results = _mapper.Map<IEnumerable<AnClientFileItemDTO>>(anClientFileItem);
            _context.ClientFiles.Add(clientFile);
            _context.AddRange(results);
            //_context.AnClientFileItems.Add(anClientFileItem);

            try
            {

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
              
             
                    throw;
                
            }
            // var clientDetails=_context.AnClientFileDetails.FromSqlRaw(sqlstr2);

            return Ok(new { data=clientFile, message = "clientFile Copied Successfully", code = 200 });
        }

        // DELETE: api/ClientFiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientFile(int id,int userId)
        {
            var clientfile = await GetById(id);

            if (!GetUser(userId) && clientfile.FinalStatusId == 1)
            {
                return BadRequest(new { message = "you are not authorized to edit this item", code = 400 });
            }
            if (_context.ClientFiles == null)
            {
                return BadRequest();
            }

            var clientFile =  _context.ClientFiles.Include(c => c.AnCuttingListDetails).Include(c => c.Client).Include(c => c.ClientFileProperties).Include(c=>c.AnClientFileItems).FirstOrDefault(c=>c.ClientFileId==id);
            if (clientFile == null)
            {
                return BadRequest();
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
        private bool GetUser(int id)
        {
            var user= _context.Users.FirstOrDefault(u => u.UserId == id);
            if (isAdmin(user))
            {
                return true;
            }
            return false;
        }
        private bool isAdmin(User user)
        {
            //var user=GetUser(id);
           if (user.IsAdmin==1)
            {
                return true;
            }
            return false;
        }
     
    }
}
