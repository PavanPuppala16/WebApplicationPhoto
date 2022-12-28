using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPhoto.Controllers
{
    public class mainController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }
    }
}
