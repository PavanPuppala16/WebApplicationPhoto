using Microsoft.AspNetCore.Mvc;
using System.Data.OleDb;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using WebApplicationPhoto.Models;
using Microsoft.AspNetCore.Mvc;
namespace WebApplicationPhoto.Controllers
{
    public class EcommerceController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult LayoutCheck()
        {
            return View();
        }
    }
}
