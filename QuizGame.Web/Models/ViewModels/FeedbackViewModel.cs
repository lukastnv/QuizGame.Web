namespace QuizGame.Web.ViewModels
{
    public class FeedbackViewModel
    {
        public int SessionId { get; set; }
        public int QuestionId { get; set; }
        public int Index { get; set; }

        public bool IsCorrect { get; set; }
        public string CorrectAnswer { get; set; }
        public string SelectedAnswer { get; set; }

        public int CurrentScore { get; set; }
        public int TotalQuestions { get; set; }
    }
}
