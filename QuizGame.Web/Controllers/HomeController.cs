using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QuizGame.Web.Data;

namespace QuizGame.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuizDbContext _context;

        public HomeController(QuizDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var themes = _context.Themes.ToList();
            return View(themes);
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
