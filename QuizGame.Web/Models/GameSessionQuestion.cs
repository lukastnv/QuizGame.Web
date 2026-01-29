namespace QuizGame.Web.Models
{
    public class GameSessionQuestion
    {
        public int Id { get; set; }

        public int GameSessionId { get; set; }
        public GameSession GameSession { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public int? SelectedAnswerId { get; set; }
        public AnswerOption SelectedAnswer { get; set; }

        public bool IsCorrect { get; set; }

        public bool IsAnswered { get; set; }
    }
}
