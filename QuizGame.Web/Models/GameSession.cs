using QuizGame.Web.Models.Enums;

namespace QuizGame.Web.Models
{
    public class GameSession
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int ThemeId { get; set; }
        public Theme Theme { get; set; }
        public DifficultyLevel Difficulty { get; set; }

        public int Score { get; set; }
        public DateTime StartTime { get; set; }

        public ICollection<GameSessionQuestion> Questions { get; set; }
    }
}
