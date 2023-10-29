using Louver.DataModel;
using Louver.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

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
        public IActionResult getClientReport1(int clientFileID,string typeId)
        {
            //string typeID = "";
            //var PclientFileId = new SqlParameter("@pClientFileID", System.Data.SqlDbType.Int);
            //var PtypeID = new SqlParameter("@pCreatedBy", System.Data.SqlDbType.Int);
            //PclientFileId.Value = clientFileID; PtypeID.Value = typeID;
            //var sqlString = $"AN_GetClientReport1 {clientFileID}";
            ////List<object> Report=new List<object>();

            ////var Report = _context.Database.ExecuteSql($"EXEC AN_GetClientReport1 {clientFileID}");
            //var Report = _context.test(clientFileID).ToList();



            //if (Report != null)
            //{
            //    return BadRequest(new { message = " no reports exist", code = 400 });
            //}
            //return Ok(new {data=Report,code=200, message = "Success" });
            string connectionString = "Data Source=194.163.132.242\\\\SQLEXPRESS,50069;Initial Catalog=kitchen4;User ID=kitchen1;Password=kit123;TrustServerCertificate=True;";
            using SqlConnection connection = new SqlConnection(connectionString);
            string x = "";
                List<object> Report1= new List<object>();
            int dataCount = 0;
            try
            {
                connection.Open();

                using SqlCommand cmd = new SqlCommand("AN_GetClientReport1", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@pClientFileID", clientFileID));
                cmd.Parameters.Add(new SqlParameter("@TypeID", typeId));
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Access data using reader
                    object report = new
                    {
                        ClientName = reader["ClientName"].ToString(),
                         CientNo = reader["CientNo"].ToString(),
                        KitchenTypeDesc = reader["KitchenTypeDesc"].ToString(),

                        TypeWoodDesc = reader["TypeWoodDesc"].ToString(),
                        Team1 = reader["Team1"].ToString(),
                        team2 = reader["team2"].ToString(),
                        teammembers = reader["teammembers"].ToString(),
                        startDate = reader["startDate"].ToString(),
                        finishdate = reader["finishdate"].ToString(),
                        technical = reader["technical"].ToString(),
                        delivery = reader["delivery"].ToString(),
                        orderno = reader["orderno"].ToString(),
                        operator1 = reader["operator1"].ToString(),
                        size = reader["size"].ToString(),
                        unitNo = reader["unitNo"].ToString(),
                        unitdesc = reader["unitdesc"].ToString(),
                        TypeID = reader["TypeID"].ToString(),
                        QTY = reader["QTY"].ToString(),
                        Length = reader["Length"].ToString(),
                        Hieght = reader["Hieght"].ToString(),
                        Width = reader["Width"].ToString(),
                        GrainDesc = reader["GrainDesc"].ToString(),
                        notes = reader["notes"].ToString(),
                        colorcode = reader["colorcode"].ToString(),
                        categorycode = reader["categorycode"].ToString(),
                        CategoryCodeEn = reader["CategoryCodeEn"].ToString(),
                        PaintTeam = reader["PaintTeam"].ToString(),
                        operatorteam = reader["operatorteam"].ToString(),
                        sub1 = reader["sub1"].ToString(),
                        sub2 = reader["sub2"].ToString(),
                        maincolor = reader["maincolor"].ToString(),
                        PrintDate = reader["PrintDate"].ToString(),
                        UnitColorCode = reader["UnitColorCode"].ToString(),

                        carcasdesc = reader["carcasdesc"].ToString()
                    };
                   
                    
                    Report1.Add(report);
                    dataCount = Report1.Count;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Ok(new
            {
                data = Report1,
                massage = "Success",
                count = dataCount
            }) ;
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
