using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizGame.Web.Data;
using QuizGame.Web.Models.Enums;

namespace QuizGame.Web.Controllers
{
    public class RankingController : Controller
    {
        private readonly QuizDbContext _context;

        public RankingController(QuizDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? themeId, DifficultyLevel? difficulty)
        {
            // 🔹 Lista de temas
            ViewBag.Themes = _context.Themes.ToList();

            // 🔹 Dificuldades
            ViewBag.Difficulties = Enum.GetValues(typeof(DifficultyLevel));

            ViewBag.SelectedThemeId = themeId;
            ViewBag.SelectedDifficulty = difficulty;

            if (!themeId.HasValue)
            {
                ViewBag.Title = "Selecione um tema";
                ViewBag.IsFootball = false;
                return View(new List<dynamic>());
            }

            var theme = _context.Themes.Find(themeId.Value);
            if (theme == null)
                return NotFound();

            bool isFootball = theme.Name == "Futebol";
            ViewBag.IsFootball = isFootball;

            ViewBag.Title = theme.Name;

            var query = _context.GameSessions
                .Include(s => s.Player)
                .Include(s => s.Questions)
                .Where(s => s.ThemeId == themeId.Value);

            // 🔹 Aplica dificuldade SOMENTE se for Futebol
            if (isFootball && difficulty.HasValue)
            {
                query = query.Where(s => s.Difficulty == difficulty);
                ViewBag.Title = $"{theme.Name} - {difficulty}";
            }

            var ranking = query
                .OrderByDescending(s => s.Score)
                .ThenBy(s => s.StartTime)
                .Take(10)
                .Select(s => new
                {
                    PlayerName = s.Player.Name,
                    Score = s.Score,
                    Difficulty = s.Difficulty,
                    TotalQuestions = s.Questions.Count
                })
                .ToList<dynamic>();

            return View(ranking);
        }
    }
}
