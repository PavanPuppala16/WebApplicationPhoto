using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPhoto.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult InsertData()
        {
            return View();
        }
        public IActionResult checking()
        {
            return View();
        }
    }
}
