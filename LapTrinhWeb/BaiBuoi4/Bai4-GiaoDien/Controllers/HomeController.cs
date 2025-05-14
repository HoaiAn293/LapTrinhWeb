using Bai4_GiaoDien.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bai4_GiaoDien.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
