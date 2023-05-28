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
    public class StatusController : ControllerBase
    {
        private readonly LouverContext _context;
        private readonly IMapper _mapper;
        public StatusController(LouverContext context, IMapper mapper = null)
        {
            _context = context;
            _mapper = mapper;
        }



        // GET: api/Status/5
        [HttpGet("MaterialID")]
        public async Task<ActionResult<Status>> GetMaterialID()
        {
            if (_context.Statuses == null)
            {
                return NotFound();
            }
            var status = await _context.Statuses.Where(s=>s.StatusCategoryId==18).Select(
                cF => new {
                    statusId = cF.StatusId,
                    name = cF.Description + cF.DefaultDesc
                }
                ).ToListAsync();
            

            if (status == null)
            {
                return NotFound();
            }

            return Ok(status);
        }
        [HttpGet("Thickness")]
        public async Task<ActionResult<Status>> GetThickness()
        {
            if (_context.Statuses == null)
            {
                return NotFound();
            }
            var status = await _context.Statuses.Where(s => s.StatusCategoryId == 97).Select(
                cF => new {
                    statusId = cF.StatusId,
                    name = cF.Description + cF.DefaultDesc
                }
                ).ToListAsync();


            if (status == null)
            {
                return NotFound();
            }

            return Ok(status);
        }
        [HttpGet("Size")]
        public async Task<ActionResult<Status>> GetSize()
        {
            if (_context.Statuses == null)
            {
                return NotFound();
            }
            var status = await _context.Statuses.Where(s => s.StatusCategoryId == 89).Select(
                cF => new {
                    statusId = cF.StatusId,
                    name = cF.Description + cF.DefaultDesc
                }
                ).ToListAsync();


            if (status == null)
            {
                return NotFound();
            }

            return Ok(status);
        }
        [HttpGet("Unit")]
        public async Task<ActionResult<Status>> GetUnit()
        {
            if (_context.Statuses == null)
            {
                return NotFound();
            }
            var units = await _context.Statuses.Where(u=>u.StatusCategoryId==2).Select(
                cF => new {
                    statusId=cF.StatusId,
                    name=cF.Description+cF.DefaultDesc
                }
                ).ToListAsync();
           

            if (units == null)
            {
                return NotFound();
            }

            return Ok(units);
        }

    }
       
}
