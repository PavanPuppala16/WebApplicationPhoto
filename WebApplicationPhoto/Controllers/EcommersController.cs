using Microsoft.AspNetCore.Mvc;
using WebApplicationPhoto.Data;

namespace WebApplicationPhoto.Controllers
{
    public class EcommersController : Controller
    {


        public IActionResult Buy()
        {
            return View(Ecommerce_logics_el.GetALlDataDummy());
        }

















































        public IActionResult Index()
        {
            return View(Ecommerce_logics_el.GetALlDataDummy());
        }
        public IActionResult Index1()
        {
            return View(DisplayData.GetALLData());
        }

        public IActionResult Id()
        {
            return View(Ecommerce_logics_el.GetALlDataDummy());
        }
        public IActionResult Layout()
        {
            return View();
        }
        public IActionResult ItemDisplay()
        {
            return View(Ecommerce_logics_el.GetALlDataDummy());
        }
        public IActionResult calculator()
        {
            return View();
        }
    }
}
