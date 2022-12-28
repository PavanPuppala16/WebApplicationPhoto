using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using WebApplicationPhoto.Models;

namespace WebApplicationPhoto.Controllers
{
    public class UploadingController : Controller
    {
public IActionResult Upload(List<IFormFile> PostedFiles, Upload obj) 
        { foreach (IFormFile PostedFile in PostedFiles) 
            { string fileName = Path.GetFileName(PostedFile.FileName); 
                string type = PostedFile.ContentType; byte[] bytes = null; 
                using (MemoryStream ms = new MemoryStream()) { PostedFile.CopyTo(ms);
                    bytes = ms.ToArray(); } var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
                string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
                using (SqlConnection con = new SqlConnection(dbconnectionstr))
                { SqlCommand cmd = new SqlCommand("sp_upload", con);
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@Product_Name", obj.Product_Name); 
                    cmd.Parameters.AddWithValue("@Description", obj.Description); 
                    cmd.Parameters.AddWithValue("@Name", fileName);
                    cmd.Parameters.AddWithValue("@ContentType", type); 
                    cmd.Parameters.AddWithValue("@Data", bytes);
                    cmd.Connection = con;
                    con.Open(); cmd.ExecuteNonQuery(); con.Close(); } }
            return View(); }


    }
}
