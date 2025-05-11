using Buoi3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi3.Controllers
{
    public class StudentController : Controller
    {
        private static List<StudentModel> registeredStudents = new List<StudentModel>();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KQ(StudentModel student)
        {
            registeredStudents.Add(student);
            int sameMajorCount = registeredStudents
                .Count(s => s.ChuyenNganh == student.ChuyenNganh);

            ViewBag.MSSV = student.MSSV;
            ViewBag.HoTen = student.HoTen;
            ViewBag.ChuyenNganh = student.ChuyenNganh;
            ViewBag.SoLuong = sameMajorCount;

            return View();
        }
    }
}
