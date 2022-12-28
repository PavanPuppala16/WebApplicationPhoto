using System.Net.Mime;
using System.Xml.Linq;

namespace WebApplicationPhoto.Models
{
    public class Uploads
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    public class Insert
    {
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public string Data { get; set; }
    }
   
}
