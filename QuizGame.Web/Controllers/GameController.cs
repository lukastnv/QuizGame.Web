using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizGame.Web.Data;
using QuizGame.Web.Models;
using QuizGame.Web.Models.Enums;
using QuizGame.Web.Models.ViewModels;
using QuizGame.Web.ViewModels;

namespace QuizGame.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly QuizDbContext _context;

        public GameController(QuizDbContext context)
        {
            _context = context;
        }

        //------------------------------------GET START---------------------------------------------------
        public IActionResult Start(int? themeId)
        {
            ViewBag.Themes = _context.Themes.ToList();
            ViewBag.SelectedThemeId = themeId;

            StartGameViewModel model = null;

            if (themeId.HasValue)
            {
                var theme = _context.Themes.Find(themeId.Value);
                if (theme == null)
                    return NotFound();

                ViewBag.IsFootball = theme.Name == "Futebol";

                model = new StartGameViewModel
                {
                    ThemeId = theme.Id,
                    ThemeName = theme.Name
                };
            }
            else
            {
                ViewBag.IsFootball = false;
            }

            return View(model);
        }


        //------------------------------------POST START---------------------------------------------------
        [HttpPost]
        public IActionResult Start(int themeId, string playerName, DifficultyLevel difficulty)
        {
            var theme = _context.Themes.FirstOrDefault(t => t.Id == themeId);

            if (theme == null)
            {
                return NotFound();
            }

            if (string.IsNullOrWhiteSpace(playerName))
                return RedirectToAction("Start", new { themeId });

            // Buscar ou criar jogador
            var player = _context.Players
                .FirstOrDefault(p => p.Name == playerName);

            if (player == null)
            {
                player = new Player
                {
                    Name = playerName
                };
                _context.Players.Add(player);
                _context.SaveChanges();
            }

            // Sortear perguntas do tema + dificuldade
            int totalQuestions;

            bool isFootball = theme.Name == "Futebol";

            if (isFootball)
            {
                totalQuestions = difficulty == DifficultyLevel.Easy ? 15 : 30;
            }
            else
            {
                totalQuestions = 20; // padrão para outros temas
            }

            var questionsQuery = _context.Questions
                .Where(q => q.ThemeId == theme.Id);

            if (isFootball)
            {
                questionsQuery = questionsQuery
                    .Where(q => q.Difficulty == difficulty);
            }

            var questions = questionsQuery
                .ToList()
                .OrderBy(q => Guid.NewGuid())
                .Take(totalQuestions)
                .ToList();

            // 🔴 Validação CRÍTICA
            if (!questions.Any())
            {
                throw new Exception("Nenhuma pergunta encontrada para esse tema e dificuldade.");
            }

            // Criar sessão de jogo (SÓ AGORA)
            var session = new GameSession
            {
                PlayerId = player.Id,
                ThemeId = themeId,
                Difficulty = isFootball ? difficulty : DifficultyLevel.Easy,
                StartTime = DateTime.Now,
                Score = 0
            };

            _context.GameSessions.Add(session);
            _context.SaveChanges();

            // Relacionar perguntas à sessão
            foreach (var question in questions)
            {
                _context.GameSessionQuestions.Add(new GameSessionQuestion
                {
                    GameSessionId = session.Id,
                    QuestionId = question.Id
                });
            }

            _context.SaveChanges();

            // Redirecionar para primeira pergunta
            return RedirectToAction("Question", new { sessionId = session.Id, index = 0 });
        }

        //------------------------------------GET QUESTION---------------------------------------------------
        public IActionResult Question(int sessionId)
        {
            var session = _context.GameSessions
                .Include(s => s.Theme)
                .Include(s => s.Questions)
                    .ThenInclude(gq => gq.Question)
                        .ThenInclude(q => q.AnswerOptions)
                .FirstOrDefault(s => s.Id == sessionId);

            if (session == null)
                return NotFound();

            var nextGq = session.Questions
                .Where(q => !q.IsAnswered)
                .OrderBy(q => q.Id)
                .FirstOrDefault();

            if (nextGq == null)
                return RedirectToAction("Result", new { sessionId });

            //-------------------- BLOCO TEMPO DA QUESTÃO -----------------------
            int timeLimit = 15; // padrão para a maioria dos temas

            if (session.Theme.Name == "Futebol")
            {
                timeLimit = session.Difficulty == DifficultyLevel.Easy ? 15 : 10;
            }
            else if (session.Theme.Name == "League of Legends")
            {
                timeLimit = 20;
            }
            //-------------------------------------------------------------------

            var results = session.Questions
                .OrderBy(q => q.Id)
                .Select(q =>
                    q.IsAnswered
                        ? q.IsCorrect        // true ou false
                        : (bool?)null        // ainda não respondida
                )
                .ToList();

            var vm = new QuestionViewModel
            {
                SessionId = sessionId,
                QuestionId = nextGq.QuestionId,
                QuestionText = nextGq.Question.Text,
                Answers = nextGq.Question.AnswerOptions,

                Index = session.Questions.Count(q => q.IsAnswered),
                TotalQuestions = session.Questions.Count,

                TimeLimitSeconds = timeLimit,
                Score = session.Score,
                Results = results
            };

            return View(vm);
        }



        //------------------------------------POST ANSWER---------------------------------------------------
        [HttpPost]
        public IActionResult Answer(int sessionId, int questionId, int? selectedAnswerId)
        {
            var gq = _context.GameSessionQuestions
                .Include(x => x.Question)
                    .ThenInclude(q => q.AnswerOptions)
                .FirstOrDefault(x =>
                    x.GameSessionId == sessionId &&
                    x.QuestionId == questionId);

            if (gq == null)
                return NotFound();

            if (gq.IsAnswered)
                return RedirectToAction("Question", new { sessionId });

            gq.IsAnswered = true;

            AnswerOption selectedAnswer = null;
            bool isCorrect = false;

            if (selectedAnswerId.HasValue)
            {
                gq.SelectedAnswerId = selectedAnswerId.Value;

                selectedAnswer = gq.Question.AnswerOptions
                    .FirstOrDefault(a => a.Id == selectedAnswerId.Value);

                if (selectedAnswer != null && selectedAnswer.IsCorrect)
                {
                    isCorrect = true;

                    var session = _context.GameSessions.Find(sessionId);
                    session.Score += 1;
                }
            }

            // ⏱️ Timeout ou erro
            gq.IsCorrect = isCorrect;

            var correctAnswer = gq.Question.AnswerOptions
                .First(a => a.IsCorrect);

            var gameSession = _context.GameSessions.Find(sessionId);

            _context.SaveChanges();

            var vm = new FeedbackViewModel
            {
                SessionId = sessionId,
                QuestionId = questionId,
                Index = _context.GameSessionQuestions
                    .Count(x => x.GameSessionId == sessionId && x.IsAnswered) - 1,

                IsCorrect = isCorrect,
                SelectedAnswer = selectedAnswer?.Text,
                CorrectAnswer = correctAnswer.Text,
                CurrentScore = gameSession.Score,
                TotalQuestions = _context.GameSessionQuestions
                    .Count(x => x.GameSessionId == sessionId)
            };

            return View("Feedback", vm);
        }


        //------------------------------------ACTION RESULT---------------------------------------------------
        public IActionResult Result(int sessionId)
        {
            var session = _context.GameSessions
                .Include(s => s.Player)
                .Include(s => s.Theme)
                .Include(s => s.Questions)
                    .ThenInclude(gq => gq.Question)
                        .ThenInclude(q => q.AnswerOptions)
                .Include(s => s.Questions)
                    .ThenInclude(gq => gq.SelectedAnswer)
                .FirstOrDefault(s => s.Id == sessionId);

            if (session == null)
                return NotFound();

            int totalQuestions = session.Questions.Count;
            int score = session.Score;

            double percent = totalQuestions == 0
                ? 0
                : (double)score / totalQuestions * 100;

            string message;

            if (percent >= 80)
                message = "🏆 Performance incrível! Você mandou muito bem!";
            else if (percent >= 50)
                message = "👏 Bom jogo! Dá pra melhorar ainda mais!";
            else
                message = "😅 Não foi dessa vez, mas continue tentando!";

            // 🔥 Envia para a View
            ViewBag.ResultMessage = message;
            ViewBag.Percent = Math.Round(percent);

            return View(session);
        }

    }
}
