using QuizGame.Web.Data;
using QuizGame.Web.Models;

public static class ThemesSeed
{
    public static void Seed(QuizDbContext context)
    {
        if (context.Themes.Any())
            return;

        context.Themes.AddRange(
            new Theme { Name = "Futebol" },
            new Theme { Name = "League of Legends" },
            new Theme { Name = "Counter Strike" }
        );

        context.SaveChanges();
    }
}
