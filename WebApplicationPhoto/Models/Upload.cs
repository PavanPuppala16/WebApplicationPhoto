namespace WebApplicationPhoto.Models
{
    public class Upload
    {
        
            public int Id { get; set; }
            public string Product_Name { get; set; }
            public string Description { get; set; }
            public string Name { get; set; }
            public string ContentType { get; set; }
            public byte[] Data { get; set; }
        
    }
}
