namespace WebApplicationPhoto.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Image { get; set; }
        public int Product_Price { get; set; }

        public int Product_Qulaity { get; set; } 
    }
    public class Model
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
    public class RegisterForm
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string PassWord { get; set; }
        public string MobileNo { get; set; }
        public string Gender { get; set; }
    }
}
