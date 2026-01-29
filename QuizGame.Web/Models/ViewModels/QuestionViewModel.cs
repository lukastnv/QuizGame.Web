using QuizGame.Web.Models;
using System.Collections.Generic;

namespace QuizGame.Web.ViewModels
{
    public class QuestionViewModel
    {
        public int SessionId { get; set; }
        public int QuestionId { get; set; }
        public int Index { get; set; }

        public string QuestionText { get; set; }

        public IEnumerable<AnswerOption> Answers { get; set; }

        public int TimeLimitSeconds { get; set; }
        public int TotalQuestions { get; set; }

        public int Score { get; set; }
        public List<bool?> Results { get; set; } = new();
    }
}
