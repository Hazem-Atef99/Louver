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
    public class TeamsController : ControllerBase
    {
        private readonly LouverContext _context;

        public TeamsController(LouverContext context)
        {
            _context = context;
        }

        // GET: api/Teams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeams()
        {
          if (_context.Teams == null)
          {
              return NotFound(new {message="No Data Found",code=404});
          }
          var teams = await _context.Teams.Include(t => t.Users).Include(t => t.ClientFile).Select(t => new{
          TeamId=t.Id,
          TeamName=t.TeamName,
          TeamType=t.TeamType,
          User=t.Users,
          ClientFileRelatedDates=t.ClientFileNavigation
          }).ToListAsync();
          var count = teams.Count();

            return Ok(new { data = teams, count = count, code = 200 });
        }

        // GET: api/Teams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> GetTeam(int id)
        {
          if (_context.Teams == null)
          {
                return NotFound(new { message = "No Data Found", code = 404 });
            }
            var team = await _context.Teams.FindAsync(id);

            if (team == null)
            {
                return NotFound(new { message = "No Data Found", code = 404 });
            }

            return Ok(new { data = team, code = 200 });
        }
        [HttpPut("AddToClientFile")]
        public async Task<IActionResult> addUserToTeam( int id, int clienFileId)
        {
            //if (!GetUser(userId))
            //{
            //    return BadRequest(new { message = "you are not authorized", code = 400 });
            //}
            var team = await GetById(id);
            team.ClientFileId= clienFileId;
             _context.Update(team);
            try
            {
                 _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok(new {Message="Team Added"});
        }

        // PUT: api/Teams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeam(int id, Team team)
        {
            if (id != team.Id)
            {
                return BadRequest(new { Message = "error", code = 400 });
            }

            _context.Entry(team).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(id))
                {
                    return BadRequest(new {Message="error",code=400});
                }
                else
                {
                    throw;
                }
            }

            return Ok(new {data=team,message="Team Updated",code=200});
        }

        // POST: api/Teams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Team>> PostTeam(Team team)
        {
          if (_context.Teams == null)
          {
              return Problem("Entity set 'LouverContext.Teams'  is null.");
          }
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeam", new { id = team.Id }, team);
        }

        // DELETE: api/Teams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            if (_context.Teams == null)
            {
                return BadRequest(new { Message = "error", code = 400 });
            }
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return BadRequest(new { Message = "error", code = 400 });
            }

            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();

            return Ok(new {Message="deleted",code=200});
        }

        private bool TeamExists(int id)
        {
            return (_context.Teams?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        private Task<Team> GetById(int id)
        {
            return _context.Teams.FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
