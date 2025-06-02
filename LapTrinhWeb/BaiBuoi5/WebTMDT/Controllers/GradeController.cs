using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTMDT.Models;


namespace WebTMDT.Controllers
{
    public class GradeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GradeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Grade> listGrade = _context.Grades.Include(g => g.Students).ToList();
            return View(listGrade);
        }
    }
}
