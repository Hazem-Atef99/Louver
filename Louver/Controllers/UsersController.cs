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
                return NotFound();
            }
            var user = await _context.Users.Where(u => u.UserName == userName && u.Password == password && u.StatusId == 1).ToListAsync();

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
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
        //        return NotFound();
        //    }
        //    var user = await _context.Users
        //        .FromSqlRaw("exec GetUsers @pUserName, @passwordHash,@pStatusID,@pFlag", userNameParam, passwordParam, statusIDParam, flagParam)
        //        .ToListAsync();

        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok( user);
        //}
       


       
    }
}
