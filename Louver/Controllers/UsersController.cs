using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Louver.Models;
using Microsoft.Data.SqlClient;
using DocumentFormat.OpenXml.Spreadsheet;
using Louver.DataModel;

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
        [HttpGet("getAllUsers")]
        public async Task<ActionResult<User>> GetAllUsers(int userId)
        {
            if (_context.Users == null) {
                return BadRequest();
            }
            if (!GetUser(userId))
            {
                return BadRequest(new { message = "you are not authorized", code = 400 });
            }
            var Users = await _context.Users.ToListAsync();
            return Ok(new {data=Users,code=200});
        }
        [HttpGet("getAssempleTeam")]
        public async Task<ActionResult<User>> getAssempleTeam(int userId)
        {
            if (_context.Users == null)
            {
                return BadRequest();
            }
            if (!GetUser(userId))
            {
                return BadRequest(new { message = "you are not authorized", code = 400 });
            }
            var users = await _context.Users.Where(u => u.UserTypeId==6).ToListAsync();
            var datacount = users.Count();
            if (datacount == 0)
            {
                return NotFound(new { Message = "No Users Found", Code = 404 });
            }
            if (users == null)
            {
                return BadRequest();
            }

            return Ok(new { data=users,count=datacount,code=200 });
        }
        [HttpGet("getOperations")]
        public async Task<ActionResult<User>> getOperation(int userId)
        {
            if (_context.Users == null)
            {
                return BadRequest();
            }
            if (!GetUser(userId))
            {
                return BadRequest(new { message = "you are not authorized", code = 400 });
            }
            var users = await _context.Users.Where(u => u.UserTypeId == 5).ToListAsync();
            var datacount = users.Count();
            if (datacount == 0)
            {
                return NotFound(new { Message = "No Users Found", Code = 404 });
            }
            if (users == null)
            {
                return BadRequest();
            }

            return Ok(new { data = users, count = datacount, code = 200 });
        }
        [HttpGet("getPainting")]
        public async Task<ActionResult<User>> getPainting(int userId)
        {
            if (_context.Users == null)
            {
                return BadRequest();
            }
            if (!GetUser(userId))
            {
                return BadRequest(new { message = "you are not authorized", code = 400 });
            }
            var users = await _context.Users.Where(u => u.UserTypeId == 4).ToListAsync();
            var datacount = users.Count();
            if (datacount == 0)
            {
                return NotFound(new { Message = "No Users Found", Code = 404 });
            }
            if (users == null)
            {
                return BadRequest();
            }

            return Ok(new { data = users, count = datacount, code = 200 });
        }
        [HttpPut("Add_Assemple_Team")]
        public async Task<IActionResult> AddToAssempleTeam(int id, int userId)
        {
            if (!GetUser(userId))
            {
                return BadRequest(new { message = "you are not authorized", code = 400 });
            }
            var user = await GetById(id);
            user.UserTypeId = 6;
            _context.Update(user);
            _context.SaveChanges();
            return Ok(new {Message = " User Added Successfully",Code=200});
        }
        [HttpPut("Add_Operating_Team")]
        public async Task<IActionResult> AddToOperatingTeam(int id, int userId)
        {
            if (!GetUser(userId))
            {
                return BadRequest(new { message = "you are not authorized", code = 400 });
            }
            var user = await GetById(id);
            user.UserTypeId = 5;
            _context.Update(user);
            _context.SaveChanges();
            return Ok(new { Message = " User Added Successfully", Code = 200 });
        }
        [HttpPut("Add_Painting_Team")]
        public async Task<IActionResult> AddToPaintingTeam(int id, int userId)
        {
            if (!GetUser(userId))
            {
                return BadRequest(new { message = "you are not authorized", code = 400 });
            }
            var user = await GetById(id);
            user.UserTypeId = 4;
            _context.Update(user);
            _context.SaveChanges();
            return Ok(new { Message = " User Added Successfully", Code = 200 });
        }
        private Task<User> GetById(int id)
        {
            return _context.Users.FirstOrDefaultAsync(m => m.UserId == id);
        }
        private bool GetUser(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == id);
            if (isAdmin(user))
            {
                return true;
            }
            return false;
        }
        private bool isAdmin(User user)
        {
            //var user=GetUser(id);
            if (user.IsAdmin == 1)
            {
                return true;
            }
            return false;
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
