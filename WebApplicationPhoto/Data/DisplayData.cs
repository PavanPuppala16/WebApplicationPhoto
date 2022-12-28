using System.Data.SqlClient;
using System.Data;
using WebApplicationPhoto.Models;

namespace WebApplicationPhoto.Data
{
    public class DisplayData
    {
        public static List<Uploads> GetALLData()
        {
            List<Uploads> obj = new List<Uploads>();
            var dbconfig = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from tblFiles ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    obj.Add(
                        new Uploads
                        {
                            Id = Convert.ToInt32(dr["Id"].ToString()),
                            Name = dr["Name"].ToString()
                            

                        }
                        );
                }
                return obj;
            }
        }
    }
}
