using Louver.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Louver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly Kitchen4Context _context;

        public ReportsController(Kitchen4Context context)
        {
            _context = context;
        }
        [HttpGet("getClientReport1")]
        public IActionResult getClientReport1(int clientFileID)
        {
            string typeID = "";
            var PclientFileId = new SqlParameter("@pClientFileID", System.Data.SqlDbType.Int);
            var PtypeID = new SqlParameter("@pCreatedBy", System.Data.SqlDbType.Int);
            PclientFileId.Value = clientFileID; PtypeID.Value = typeID;
            var sqlString = $"AN_GetClientReport1 {clientFileID}";
            var Report = _context.Database.SqlQuery<object>($"AN_GetClientReport1 {clientFileID}");
            if (ReferenceEquals(Report, null))
            {
                return BadRequest(new { message = " no reports exist", code = 400 });
            }
            return Ok(new {data=Report,code=200, message = "Success" });
        }
        [HttpGet("getClientReport2")]
        public IActionResult getClientReport2(int clientFileID)
        {
            var sqlString = $"AN_GetClientReport2{clientFileID}";
            var Report = _context.Database.ExecuteSqlRaw(sqlString);
            if (ReferenceEquals(Report, null))
            {
                return BadRequest(new { message = " no reports exist", code = 400 });
            }
            return Ok(new { data = Report, code = 200, message = "Success" });
        }
        [HttpGet("getClientReport3")]
        public IActionResult getClientReport3(int clientFileID)
        {
            string typeID = "1,2";
            var sqlString = $"AN_GetClientReport3{clientFileID},{typeID}";
            var Report = _context.Database.ExecuteSqlRaw(sqlString);
            if (ReferenceEquals(Report, null))
            {
                return BadRequest(new { message = " no reports exist", code = 400 });
            }
            return Ok(new { data = Report, code = 200, message = "Success" });
        }
    }
}
