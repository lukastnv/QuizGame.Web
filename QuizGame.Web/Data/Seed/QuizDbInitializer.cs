using QuizGame.Web.Data;
using QuizGame.Web.Data.Seed;

public static class QuizDbInitializer
{
    public static void Seed(QuizDbContext context)
    {
        ThemesSeed.Seed(context);


        FutebolSeed.Seed(context);
        LolSeed.Seed(context);
        CounterStrikeSeed.Seed(context);

        //STANDBY - DESATIVADOS
        //AnimeSeed.Seed(context);
        //MusicaSeed.Seed(context);
    }
}
