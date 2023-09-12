using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Louver.Models;
using Microsoft.Data.SqlClient;

namespace Louver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly LouverContext _context;

        public UsersController(LouverContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUser(string userName, string password)
        {
            if (_context.Users == null)
            {
                return BadRequest();
            }
            var user = await _context.Users.Where(u => u.UserName == userName && u.Password == password && u.StatusId == 1).ToListAsync();

            if (user == null)
            {
                return BadRequest();
            }
            if (user.Count() == 0) {
                return BadRequest(new {message="user not exist", code=404});
            }

            return Ok(user);
        }
        [HttpGet("getAssempleTeam")]
        public async Task<ActionResult<User>> getAssempleTeam()
        {
            if (_context.Users == null)
            {
                return BadRequest();
            }
            var users = await _context.Users.Where(u => u.UserTypeId==6).ToListAsync();
            var datacount = users.Count();

            if (users == null)
            {
                return BadRequest();
            }

            return Ok(new { data=users,count=datacount,code=200 });
        }
        [HttpGet("getForman")]
        public async Task<ActionResult<User>> getForman()
        {
            if (_context.Users == null)
            {
                return BadRequest();
            }
            var users = await _context.Users.Where(u => u.UserTypeId == 5).ToListAsync();
            var datacount = users.Count();

            if (users == null)
            {
                return BadRequest();
            }

            return Ok(new { data = users, count = datacount, code = 200 });
        }
        //[HttpGet]
        //public async Task<ActionResult<User>> GetUser(string userName, string password)
        //{
        //    var userNameParam = new SqlParameter("@pUserName", userName);
        //    var passwordParam = new SqlParameter("@passwordHash", password);
        //    var statusIDParam = new SqlParameter("@pStatusID ", 1);
        //    var flagParam = new SqlParameter("@pFlag", 1);



        //    if (_context.Users == null)
        //    {
        //        return BadRequest();
        //    }
        //    var user = await _context.Users
        //        .FromSqlRaw("exec GetUsers @pUserName, @passwordHash,@pStatusID,@pFlag", userNameParam, passwordParam, statusIDParam, flagParam)
        //        .ToListAsync();

        //    if (user == null)
        //    {
        //        return BadRequest();
        //    }

        //    return Ok( user);
        //}




    }
}
