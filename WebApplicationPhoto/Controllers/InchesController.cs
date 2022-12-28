using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPhoto.Controllers
{
    public class InchesController : Controller
    {
        public IActionResult Inches()
        {
            return View();
        }
        public IActionResult Converter()
        {
            return View();
        }
        
    }
}
