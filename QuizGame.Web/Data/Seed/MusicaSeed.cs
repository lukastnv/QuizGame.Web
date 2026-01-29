using QuizGame.Web.Data;
using QuizGame.Web.Models;

public static class MusicaSeed
{
    public static void Seed(QuizDbContext context)
    {
        var musica = context.Themes.First(t => t.Name == "Música");

        if (context.Questions.Any(q => q.ThemeId == musica.Id))
            return;

        var questions = new List<Question>
        {
            new Question
            {
                ThemeId = musica.Id,
                Text = "Qual banda é conhecida como 'Os Quatro de Liverpool'?",
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "The Beatles", IsCorrect = true },
                    new AnswerOption { Text = "Rolling Stones", IsCorrect = false },
                    new AnswerOption { Text = "Queen", IsCorrect = false },
                    new AnswerOption { Text = "Pink Floyd", IsCorrect = false }
                }
            },

            new Question
            {
                ThemeId = musica.Id,
                Text = "Qual desses estilos musicais surgiu no Brasil?",
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Samba", IsCorrect = true },
                    new AnswerOption { Text = "Jazz", IsCorrect = false },
                    new AnswerOption { Text = "Rock", IsCorrect = false },
                    new AnswerOption { Text = "Blues", IsCorrect = false }
                }
            },

            new Question
            {
                ThemeId = musica.Id,
                Text = "Quem é conhecido como o 'Rei do Pop'?",
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Michael Jackson", IsCorrect = true },
                    new AnswerOption { Text = "Prince", IsCorrect = false },
                    new AnswerOption { Text = "Elvis Presley", IsCorrect = false },
                    new AnswerOption { Text = "Madonna", IsCorrect = false }
                }
            }
        };

        context.Questions.AddRange(questions);
        context.SaveChanges();
    }
}
