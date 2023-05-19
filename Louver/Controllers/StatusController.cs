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
            var status = await _context.Statuses.Where(s=>s.StatusCategoryId==18).ToListAsync();
            

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
            var status = await _context.Statuses.Where(s => s.StatusCategoryId == 97).ToListAsync();


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
            var status = await _context.Statuses.Where(s => s.StatusCategoryId == 89).ToListAsync();


            if (status == null)
            {
                return NotFound();
            }

            return Ok(status);
        }

    }
       
}
