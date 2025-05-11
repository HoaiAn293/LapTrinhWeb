using Buoi3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi3.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            var sanpham = new SanPhamViewModel
            {
                TenSanPham = "Laptop ABC",
                GiaBan = 18750000,
                AnhMoTa = "/img/download.jpg"
            };

            return View(sanpham);
        }
    }
}
