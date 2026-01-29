using QuizGame.Web.Models.Enums;

namespace QuizGame.Web.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int ThemeId { get; set; }
        public Theme Theme { get; set; }

        public ICollection<AnswerOption> AnswerOptions { get; set; }

        public DifficultyLevel Difficulty { get; set; }
    }
}
