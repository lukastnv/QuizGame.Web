using QuizGame.Web.Models;
using QuizGame.Web.Models.Enums;

namespace QuizGame.Web.Data.Seed
{
    public static class AnimeSeed
    {
        public static void Seed(QuizDbContext context)
        {
            var anime = context.Themes.First(t => t.Name == "Anime");

            if (context.Questions.Any(q => q.ThemeId == anime.Id))
                return;

            context.Questions.AddRange(

                new Question
                {
                    Text = "Quem é o protagonista de Naruto?",
                    ThemeId = anime.Id,
                    AnswerOptions = new List<AnswerOption>
                    {
                    new() { Text = "Naruto Uzumaki", IsCorrect = true },
                    new() { Text = "Sasuke Uchiha", IsCorrect = false },
                    new() { Text = "Kakashi Hatake", IsCorrect = false },
                    new() { Text = "Itachi Uchiha", IsCorrect = false }
                    }
                },

                new Question
                {
                    Text = "Em Dragon Ball Z, quem derrota Freeza?",
                    ThemeId = anime.Id,
                    AnswerOptions = new List<AnswerOption>
                    {
                    new() { Text = "Goku", IsCorrect = true },
                    new() { Text = "Vegeta", IsCorrect = false },
                    new() { Text = "Gohan", IsCorrect = false },
                    new() { Text = "Piccolo", IsCorrect = false }
                    }
                }

            );

            context.SaveChanges();
        }
    }

}
