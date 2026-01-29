using QuizGame.Web.Data;
using QuizGame.Web.Models;
using QuizGame.Web.Models.Enums;

public static class FutebolSeed
{
    public static void Seed(QuizDbContext context)
    {
        var futebol = context.Themes.First(t => t.Name == "Futebol");

        // EASY
        if (!context.Questions.Any(q =>
            q.ThemeId == futebol.Id &&
            q.Difficulty == DifficultyLevel.Easy))
        {
            SeedEasy(context, futebol.Id);
        }

        // HARD
        if (!context.Questions.Any(q =>
            q.ThemeId == futebol.Id &&
            q.Difficulty == DifficultyLevel.Hard))
        {
            SeedHard(context, futebol.Id);
        }

        context.SaveChanges();
    }

    private static void SeedEasy(QuizDbContext context, int themeId)
    {
        context.Questions.AddRange(

            // ✅ CORRETA NA 1ª OPÇÃO
            new Question
            {
                Text = "Quem venceu a Copa do Mundo de 1970?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Brasil", IsCorrect = true },
                    new AnswerOption { Text = "Itália", IsCorrect = false },
                    new AnswerOption { Text = "Alemanha", IsCorrect = false },
                    new AnswerOption { Text = "Argentina", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Champions League em 2010?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Inter de Milão", IsCorrect = true },
                    new AnswerOption { Text = "Bayern de Munique", IsCorrect = false },
                    new AnswerOption { Text = "Barcelona", IsCorrect = false },
                    new AnswerOption { Text = "Chelsea", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi o capitão do Brasil na Copa de 1994?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Dunga", IsCorrect = true },
                    new AnswerOption { Text = "Romário", IsCorrect = false },
                    new AnswerOption { Text = "Bebeto", IsCorrect = false },
                    new AnswerOption { Text = "Branco", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2011?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Santos", IsCorrect = true },
                    new AnswerOption { Text = "Peñarol", IsCorrect = false },
                    new AnswerOption { Text = "Grêmio", IsCorrect = false },
                    new AnswerOption { Text = "Boca Juniors", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem ficou conhecido como 'Rei do Futebol'?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Pelé", IsCorrect = true },
                    new AnswerOption { Text = "Maradona", IsCorrect = false },
                    new AnswerOption { Text = "Zico", IsCorrect = false },
                    new AnswerOption { Text = "Garrincha", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2024?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Botafogo", IsCorrect = true },
                    new AnswerOption { Text = "Flamengo", IsCorrect = false },
                    new AnswerOption { Text = "Fluminense", IsCorrect = false },
                    new AnswerOption { Text = "Palmeiras", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Copa de 2002 Oitavas de Final - Brasil 2x0 Bélgica. Quem fez o primeiro gol?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Rivaldo", IsCorrect = true },
                    new AnswerOption { Text = "Ronaldo", IsCorrect = false },
                    new AnswerOption { Text = "Ronaldinho", IsCorrect = false },
                    new AnswerOption { Text = "Kleberson", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem é o maior artilheiro da Seleção da França?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Giroud", IsCorrect = true },
                    new() { Text = "Mbappé", IsCorrect = false },
                    new() { Text = "Henry", IsCorrect = false },
                    new() { Text = "Platini", IsCorrect = false }
                }
            },

            // ✅ CORRETA NA 2ª OPÇÃO
            new Question
            {
                Text = "Qual seleção venceu a Copa do Mundo de 2022?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Brasil", IsCorrect = false },
                    new AnswerOption { Text = "Argentina", IsCorrect = true },
                    new AnswerOption { Text = "França", IsCorrect = false },
                    new AnswerOption { Text = "Itália", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Na Copa de 2002, qual adversário Ronaldinho marcou o gol antológico de falta?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Bélgica", IsCorrect = false },
                    new AnswerOption { Text = "Inglaterra", IsCorrect = true },
                    new AnswerOption { Text = "Turquia", IsCorrect = false },
                    new AnswerOption { Text = "Estados Unidos", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual seleção venceu a Copa do Mundo de 2018?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Bélgica", IsCorrect = false },
                    new AnswerOption { Text = "França", IsCorrect = true },
                    new AnswerOption { Text = "Croácia", IsCorrect = false },
                    new AnswerOption { Text = "Inglaterra", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o Mundial de Clubes em 2005?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Internacional", IsCorrect = false },
                    new AnswerOption { Text = "São Paulo", IsCorrect = true },
                    new AnswerOption { Text = "Corinthians", IsCorrect = false },
                    new AnswerOption { Text = "Santos", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Champions League de 2025?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Arsenal", IsCorrect = false },
                    new AnswerOption { Text = "PSG", IsCorrect = true },
                    new AnswerOption { Text = "Inter de Milão", IsCorrect = false },
                    new AnswerOption { Text = "Barcelona", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube brasileiro é conhecido como 'Gigante da Colina'?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Fluminense", IsCorrect = false },
                    new AnswerOption { Text = "Vasco da Gama", IsCorrect = true },
                    new AnswerOption { Text = "São Paulo", IsCorrect = false },
                    new AnswerOption { Text = "Bahia", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Champions League de 2013?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Borussia Dortmund", IsCorrect = false },
                    new AnswerOption { Text = "Bayern de Munique", IsCorrect = true },
                    new AnswerOption { Text = "Chelsea", IsCorrect = false },
                    new AnswerOption { Text = "Real Madrid", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2021?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Botafogo", IsCorrect = false },
                    new AnswerOption { Text = "Palmeiras", IsCorrect = true },
                    new AnswerOption { Text = "Fluminense", IsCorrect = false },
                    new AnswerOption { Text = "River Plate", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem venceu a Copa do Mundo de 2010?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Holanda", IsCorrect = false },
                    new AnswerOption { Text = "Espanha", IsCorrect = true },
                    new AnswerOption { Text = "Alemanha", IsCorrect = false },
                    new AnswerOption { Text = "Uruguai", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem é o maior artilheiro da Seleção do Uruguai?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Edinson Cavani", IsCorrect = false },
                    new() { Text = "Luis Suárez", IsCorrect = true },
                    new() { Text = "Diego Forlán", IsCorrect = false },
                    new() { Text = "Loco Abreu", IsCorrect = false }
                }
            },

            // ✅ CORRETA NA 3ª OPÇÃO
            new Question
            {
                Text = "Quem foi o artilheiro da Copa do Mundo de 2002?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Rivaldo", IsCorrect = false },
                    new AnswerOption { Text = "Klose", IsCorrect = false },
                    new AnswerOption { Text = "Ronaldo", IsCorrect = true },
                    new AnswerOption { Text = "Ronaldinho", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual seleção venceu a Copa do Mundo de 1986?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Alemanha", IsCorrect = false },
                    new AnswerOption { Text = "Brasil", IsCorrect = false },
                    new AnswerOption { Text = "Argentina", IsCorrect = true },
                    new AnswerOption { Text = "Itália", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Champions League de 2009?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Chelsea", IsCorrect = false },
                    new AnswerOption { Text = "Manchester United", IsCorrect = false },
                    new AnswerOption { Text = "Barcelona", IsCorrect = true },
                    new AnswerOption { Text = "Milan", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem marcou o gol do título do Brasil na Copa de 2002?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Rivaldo", IsCorrect = false },
                    new AnswerOption { Text = "Ronaldinho", IsCorrect = false },
                    new AnswerOption { Text = "Ronaldo", IsCorrect = true },
                    new AnswerOption { Text = "Cafu", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual seleção venceu a Copa do Mundo de 1982?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Brasil", IsCorrect = false },
                    new AnswerOption { Text = "Holanda", IsCorrect = false },
                    new AnswerOption { Text = "Itália", IsCorrect = true },
                    new AnswerOption { Text = "Alemanha", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quais são os adversários do grupo do Brasil na Copa de 2026?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Marrocos, Haiti, Noruega", IsCorrect = false },
                    new() { Text = "Costa do Marfim, Escócia, Catar", IsCorrect = false },
                    new() { Text = "Marrocos, Haiti, Escócia", IsCorrect = true },
                    new() { Text = "Tunísia, Haiti, Croácia", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2013?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Internacional", IsCorrect = false },
                    new AnswerOption { Text = "San Lorenzo", IsCorrect = false },
                    new AnswerOption { Text = "Atlético-MG", IsCorrect = true },
                    new AnswerOption { Text = "River Plate", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem venceu a Copa do Mundo de 2014?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Holanda", IsCorrect = false },
                    new AnswerOption { Text = "Argentina", IsCorrect = false },
                    new AnswerOption { Text = "Alemanha", IsCorrect = true },
                    new AnswerOption { Text = "Espanha", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem é o maior artilheiro da Seleção da Espanha?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Raúl", IsCorrect = false },
                    new() { Text = "Fernando Torres", IsCorrect = false },
                    new() { Text = "David Villa", IsCorrect = true },
                    new() { Text = "Morata", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi o camisa 9 do Brasil na Copa de 2010?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Adriano", IsCorrect = false },
                    new() { Text = "Vagner Love", IsCorrect = false },
                    new() { Text = "Luis Fabiano", IsCorrect = true },
                    new() { Text = "Fred", IsCorrect = false }
                }
            },

            // ✅ CORRETA NA 4ª OPÇÃO
            new Question
            {
                Text = "Quem marcou o gol que fechou o placar na final da Copa do Mundo de 1970?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Pelé", IsCorrect = false },
                    new AnswerOption { Text = "Jairzinho", IsCorrect = false },
                    new AnswerOption { Text = "Tostão", IsCorrect = false },
                    new AnswerOption { Text = "Carlos Alberto Torres", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube brasileiro venceu o Mundial de Clubes em 2012?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Santos", IsCorrect = false },
                    new AnswerOption { Text = "São Paulo", IsCorrect = false },
                    new AnswerOption { Text = "Flamengo", IsCorrect = false },
                    new AnswerOption { Text = "Corinthians", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Quem é o maior campeão da La Liga?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Atlético de Madrid", IsCorrect = false },
                    new AnswerOption { Text = "Barcelona", IsCorrect = false },
                    new AnswerOption { Text = "Valencia", IsCorrect = false },
                    new AnswerOption { Text = "Real Madrid", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual dos goleiros abaixo não estava no elenco do Brasil na Copa de 2002?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Dida", IsCorrect = false },
                    new AnswerOption { Text = "Marcos", IsCorrect = false },
                    new AnswerOption { Text = "Rogério Ceni", IsCorrect = false },
                    new AnswerOption { Text = "Julio Cesar", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube brasileiro é conhecido como 'Peixe'?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Vasco", IsCorrect = false },
                    new AnswerOption { Text = "Botafogo", IsCorrect = false },
                    new AnswerOption { Text = "Corinthians", IsCorrect = false },
                    new AnswerOption { Text = "Santos", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual jogador brasileiro venceu a Bola de Ouro em 2005?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Ronaldo", IsCorrect = false },
                    new AnswerOption { Text = "Kaká", IsCorrect = false },
                    new AnswerOption { Text = "Rivaldo", IsCorrect = false },
                    new AnswerOption { Text = "Ronaldinho Gaúcho", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 1992?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Flamengo", IsCorrect = false },
                    new AnswerOption { Text = "Grêmio", IsCorrect = false },
                    new AnswerOption { Text = "Palmeiras", IsCorrect = false },
                    new AnswerOption { Text = "São Paulo", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Quem foi o técnico da Seleção Brasileira na Copa de 2002?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Luiz Felipe Scolari", IsCorrect = true },
                new() { Text = "Carlos Alberto Parreira", IsCorrect = false },
                new() { Text = "Vanderlei Luxemburgo", IsCorrect = false },
                new() { Text = "Zagallo", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2012?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Boca Juniors", IsCorrect = false },
                new() { Text = "Corinthians", IsCorrect = true },
                new() { Text = "Santos", IsCorrect = false },
                new() { Text = "Vélez", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube brasileiro foi o primeiro a vencer a Copa Libertadores da América?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Santos", IsCorrect = true },
                    new() { Text = "Palmeiras", IsCorrect = false },
                    new() { Text = "Grêmio", IsCorrect = false },
                    new() { Text = "Flamengo", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi o Rei da América de 2019?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Bruno Henrique", IsCorrect = false },
                    new() { Text = "Julián Álvarez", IsCorrect = false },
                    new() { Text = "Arrascaeta", IsCorrect = false },
                    new() { Text = "Gabigol", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Quem foi o primeiro campeão do Super Mundial de Clubes em 2025?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "PSG", IsCorrect = false },
                    new() { Text = "Bayern de Munique", IsCorrect = false },
                    new() { Text = "Real Madrid", IsCorrect = false },
                    new() { Text = "Chelsea", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Quantas seleções participantes terá a Copa 2026?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "32", IsCorrect = false },
                    new AnswerOption { Text = "36", IsCorrect = false },
                    new AnswerOption { Text = "42", IsCorrect = false },
                    new AnswerOption { Text = "48", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Quem é o maior artilheiro da Seleção da Inglaterra?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Easy,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Wayne Rooney", IsCorrect = false },
                    new() { Text = "David Beckham", IsCorrect = false },
                    new() { Text = "Bobby Charlton", IsCorrect = false },
                    new() { Text = "Harry Kane", IsCorrect = true }
                }
            }
        );
    }

    //--------------------------------------------- HARD QUESTIONS ---------------------------------------------
    private static void SeedHard(QuizDbContext context, int themeId)
    {
        context.Questions.AddRange(

            // =========================
            // Q1–Q10 → CORRETA NA 1ª
            // =========================

            new Question
            {
                Text = "Quem foi o artilheiro da Copa do Mundo de 1994?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Hristo Stoichkov", IsCorrect = true },
                new() { Text = "Romário", IsCorrect = false },
                new() { Text = "Gabriel Batistuta", IsCorrect = false },
                new() { Text = "Roberto Baggio", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2008?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "São Paulo", IsCorrect = true },
                new() { Text = "Fluminense", IsCorrect = false },
                new() { Text = "Flamengo", IsCorrect = false },
                new() { Text = "Corinthians", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem fez o gol do título do Brasil na Copa das Confederações 2009?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Lúcio", IsCorrect = true },
                new() { Text = "Kaká", IsCorrect = false },
                new() { Text = "Luis Fabiano", IsCorrect = false },
                new() { Text = "Juan", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual foi o primeiro país a vencer duas Copas do Mundo consecutivas?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Itália", IsCorrect = true },
                new() { Text = "Uruguai", IsCorrect = false },
                new() { Text = "Alemanha", IsCorrect = false },
                new() { Text = "Brasil", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem é o maior artilheiro da Seleção da Itália?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Luigi Riva", IsCorrect = true },
                    new() { Text = "Giuseppe Meazza", IsCorrect = false },
                    new() { Text = "Roberto Baggio", IsCorrect = false },
                    new() { Text = "Del Piero", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2012?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Fluminense", IsCorrect = true },
                new() { Text = "Palmeiras", IsCorrect = false },
                new() { Text = "Atlético-MG", IsCorrect = false },
                new() { Text = "Corinthians", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem ganhou o prêmio de Melhor Jogador da Copa de 2002?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Oliver Kahn", IsCorrect = true },
                    new AnswerOption { Text = "Ronaldo", IsCorrect = false },
                    new AnswerOption { Text = "Rivaldo", IsCorrect = false },
                    new AnswerOption { Text = "Michael Ballack", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a primeira edição da Copa Libertadores?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Peñarol", IsCorrect = true },
                new() { Text = "Nacional", IsCorrect = false },
                new() { Text = "Estudiantes", IsCorrect = false },
                new() { Text = "River Plate", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi o técnico da Seleção Italiana na Copa de 2006?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Roberto Mancini", IsCorrect = false },
                new() { Text = "Marcello Lippi", IsCorrect = true },
                new() { Text = "Carlo Ancelotti", IsCorrect = false },
                new() { Text = "Fabio Capello", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Champions League de 1999?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Manchester United", IsCorrect = true },
                new() { Text = "Bayern de Munique", IsCorrect = false },
                new() { Text = "Juventus", IsCorrect = false },
                new() { Text = "Barcelona", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2023?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Palmeiras", IsCorrect = true },
                new() { Text = "Botafogo", IsCorrect = false },
                new() { Text = "Atlético-MG", IsCorrect = false },
                new() { Text = "Grêmio", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi o capitão do Brasil na Copa de 1970?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Carlos Alberto Torres", IsCorrect = true },
                new() { Text = "Pelé", IsCorrect = false },
                new() { Text = "Gérson", IsCorrect = false },
                new() { Text = "Rivelino", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 1995?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Grêmio", IsCorrect = true },
                new() { Text = "Atlético Nacional", IsCorrect = false },
                new() { Text = "São Paulo", IsCorrect = false },
                new() { Text = "River Plate", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2016?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Palmeiras", IsCorrect = true },
                new() { Text = "Flamengo", IsCorrect = false },
                new() { Text = "Santos", IsCorrect = false },
                new() { Text = "Atlético-MG", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem venceu a Bola de Ouro em 2007?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Kaká", IsCorrect = true },
                new() { Text = "Cristiano Ronaldo", IsCorrect = false },
                new() { Text = "Messi", IsCorrect = false },
                new() { Text = "Didier Drogba", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual seleção venceu a Eurocopa de 2004?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Grécia", IsCorrect = true },
                new() { Text = "Portugal", IsCorrect = false },
                new() { Text = "França", IsCorrect = false },
                new() { Text = "Itália", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi o artilheiro da Copa de 2014?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "James Rodríguez", IsCorrect = true },
                new() { Text = "Müller", IsCorrect = false },
                new() { Text = "Messi", IsCorrect = false },
                new() { Text = "Neymar", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2009?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Estudiantes", IsCorrect = true },
                new() { Text = "Cruzeiro", IsCorrect = false },
                new() { Text = "Internacional", IsCorrect = false },
                new() { Text = "Nacional", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube revelou Julián Álvarez?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "River Plate", IsCorrect = true },
                    new() { Text = "Racing", IsCorrect = false },
                    new() { Text = "San Lorenzo", IsCorrect = false },
                    new() { Text = "Boca Juniors", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2014?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "San Lorenzo", IsCorrect = true },
                    new AnswerOption { Text = "Atlético Nacional", IsCorrect = false },
                    new AnswerOption { Text = "River Plate", IsCorrect = false },
                    new AnswerOption { Text = "Atlético-MG", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual desses clubes Samuel Eto'o NÃO jogou?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Osasuna", IsCorrect = true },
                    new() { Text = "Real Madrid", IsCorrect = false },
                    new() { Text = "Mallorca", IsCorrect = false },
                    new() { Text = "Everton", IsCorrect = false }
                }
            },

            // =========================
            // Q11–Q20 → CORRETA NA 2ª
            // =========================

            new Question
            {
                Text = "Qual clube venceu a Champions League de 2005?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Milan", IsCorrect = false },
                new() { Text = "Liverpool", IsCorrect = true },
                new() { Text = "Chelsea", IsCorrect = false },
                new() { Text = "Juventus", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2009?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "São Paulo", IsCorrect = false },
                new() { Text = "Flamengo", IsCorrect = true },
                new() { Text = "Fluminense", IsCorrect = false },
                new() { Text = "Corinthians", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual seleção venceu a Eurocopa de 2008?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Itália", IsCorrect = false },
                new() { Text = "Espanha", IsCorrect = true },
                new() { Text = "França", IsCorrect = false },
                new() { Text = "Alemanha", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2015?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "San Lorenzo", IsCorrect = false },
                    new AnswerOption { Text = "River Plate", IsCorrect = true },
                    new AnswerOption { Text = "Atlético Nacional", IsCorrect = false },
                    new AnswerOption { Text = "Tigres", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi o artilheiro da Copa do Mundo de 1998?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Batistuta", IsCorrect = false },
                new() { Text = "Davor Suker", IsCorrect = true },
                new() { Text = "Ronaldo", IsCorrect = false },
                new() { Text = "Vieri", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2013?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Fluminense", IsCorrect = false },
                new() { Text = "Cruzeiro", IsCorrect = true },
                new() { Text = "Corinthians", IsCorrect = false },
                new() { Text = "Palmeiras", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Copa do Brasil de 2011?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Coritiba", IsCorrect = false },
                new() { Text = "Vasco da Gama", IsCorrect = true },
                new() { Text = "Santos", IsCorrect = false },
                new() { Text = "Palmeiras", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem marcou o gol do título da Copa do Mundo de 2010?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Sneijder", IsCorrect = false },
                new() { Text = "Iniesta", IsCorrect = true },
                new() { Text = "Villa", IsCorrect = false },
                new() { Text = "Xavi", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2017?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Palmeiras", IsCorrect = false },
                new() { Text = "Corinthians", IsCorrect = true },
                new() { Text = "Santos", IsCorrect = false },
                new() { Text = "Grêmio", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual seleção venceu a Copa do Mundo de 1974?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Holanda", IsCorrect = false },
                new() { Text = "Alemanha Ocidental", IsCorrect = true },
                new() { Text = "Brasil", IsCorrect = false },
                new() { Text = "Itália", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube revelou Danilo (Zidanilo, ídolo de São Paulo e Corinthians)?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "São Paulo", IsCorrect = false },
                new() { Text = "Goiás", IsCorrect = true },
                new() { Text = "Vila Nova", IsCorrect = false },
                new() { Text = "Atlético-GO", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o Mundial de Clubes em 2003?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Juventus", IsCorrect = false },
                new() { Text = "Boca Juniors", IsCorrect = true },
                new() { Text = "Milan", IsCorrect = false },
                new() { Text = "Once Caldas", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi o técnico do Brasil na Copa de 1994?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Zagallo", IsCorrect = false },
                new() { Text = "Carlos Alberto Parreira", IsCorrect = true },
                new() { Text = "Felipão", IsCorrect = false },
                new() { Text = "Telê Santana", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2024?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Palmeiras", IsCorrect = false },
                new() { Text = "Botafogo", IsCorrect = true },
                new() { Text = "Flamengo", IsCorrect = false },
                new() { Text = "Cruzeiro", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2017?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Lanús", IsCorrect = false },
                    new AnswerOption { Text = "Grêmio", IsCorrect = true },
                    new AnswerOption { Text = "River Plate", IsCorrect = false },
                    new AnswerOption { Text = "Flamengo", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube revelou Jonathan Calleri?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "River Plate", IsCorrect = false },
                    new() { Text = "All Boys", IsCorrect = true },
                    new() { Text = "Boca Juniors", IsCorrect = false },
                    new() { Text = "Defensa y Justicia", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2020?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "São Paulo", IsCorrect = false },
                new() { Text = "Flamengo", IsCorrect = true },
                new() { Text = "Palmeiras", IsCorrect = false },
                new() { Text = "Atlético-MG", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Luis Suárez foi para qual clube após sair do Atlético de Madrid?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Grêmio", IsCorrect = false },
                    new() { Text = "Nacional", IsCorrect = true },
                    new() { Text = "Inter Miami", IsCorrect = false },
                    new() { Text = "Ajax", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube foi campeão da Copa do Brasil em 2008?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Botafogo", IsCorrect = false },
                    new AnswerOption { Text = "Sport", IsCorrect = true },
                    new AnswerOption { Text = "Corinthians", IsCorrect = false },
                    new AnswerOption { Text = "Vasco da Gama", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube James Rodríguez NÃO jogou?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Monaco", IsCorrect = false },
                    new AnswerOption { Text = "Girona", IsCorrect = true },
                    new AnswerOption { Text = "Porto", IsCorrect = false },
                    new AnswerOption { Text = "Everton", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube revelou Andreas Pereira?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Granada", IsCorrect = false },
                    new AnswerOption { Text = "Manchester United", IsCorrect = true },
                    new AnswerOption { Text = "Valencia", IsCorrect = false },
                    new AnswerOption { Text = "Lazio", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Gonzalo Higuaín foi revelado por qual clube?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Real Madrid", IsCorrect = false },
                    new AnswerOption { Text = "River Plate", IsCorrect = true },
                    new AnswerOption { Text = "Banfield", IsCorrect = false },
                    new AnswerOption { Text = "Rosario Central", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Jogando pelo Liverpool, qual desses torneios Steven Gerrard nunca ganhou?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Copa da Liga Inglesa", IsCorrect = false },
                    new() { Text = "Premier League", IsCorrect = true },
                    new() { Text = "Copa da UEFA", IsCorrect = false },
                    new() { Text = "Champions League", IsCorrect = false }
                }
            },

            // =========================
            // Q21–Q30 → CORRETA NA 3ª
            // =========================

            new Question
            {
                Text = "Quem foi o artilheiro da Copa do Mundo de 2006?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Ronaldo", IsCorrect = false },
                new() { Text = "Zidane", IsCorrect = false },
                new() { Text = "Klose", IsCorrect = true },
                new() { Text = "Crespo", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2010?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Cruzeiro", IsCorrect = false },
                new() { Text = "Flamengo", IsCorrect = false },
                new() { Text = "Fluminense", IsCorrect = true },
                new() { Text = "Corinthians", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Mundial de Clubes - Corinthians 1x0 Chelsea - Quem fez o gol?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Emerson Sheik", IsCorrect = false },
                new() { Text = "Paulinho", IsCorrect = false },
                new() { Text = "Guerrero", IsCorrect = true },
                new() { Text = "Danilo", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem é o maior campeão da Copa do Brasil com 6 títulos?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Corinthians", IsCorrect = false },
                new() { Text = "Flamengo", IsCorrect = false },
                new() { Text = "Cruzeiro", IsCorrect = true },
                new() { Text = "Grêmio", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2016?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Boca Juniors", IsCorrect = false },
                    new AnswerOption { Text = "River Plate", IsCorrect = false },
                    new AnswerOption { Text = "Atlético Nacional", IsCorrect = true },
                    new AnswerOption { Text = "Independiente del Valle", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2018?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Flamengo", IsCorrect = false },
                new() { Text = "Internacional", IsCorrect = false },
                new() { Text = "Palmeiras", IsCorrect = true },
                new() { Text = "Grêmio", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Ángel Di María foi revelado por qual clube?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Benfica", IsCorrect = false },
                new() { Text = "Banfield", IsCorrect = false },
                new() { Text = "Rosario Central", IsCorrect = true },
                new() { Text = "Estudiantes", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2014?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Internacional", IsCorrect = false },
                new() { Text = "São Paulo", IsCorrect = false },
                new() { Text = "Cruzeiro", IsCorrect = true },
                new() { Text = "Corinthians", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual seleção venceu a Eurocopa de 2012?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Itália", IsCorrect = false },
                new() { Text = "França", IsCorrect = false },
                new() { Text = "Espanha", IsCorrect = true },
                new() { Text = "Alemanha", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual seleção perdeu três finais de Copa do Mundo?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Itália", IsCorrect = false },
                new() { Text = "França", IsCorrect = false },
                new() { Text = "Holanda", IsCorrect = true },
                new() { Text = "Alemanha", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2008?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Fluminense", IsCorrect = false },
                new() { Text = "Internacional", IsCorrect = false },
                new() { Text = "LDU", IsCorrect = true },
                new() { Text = "Boca Juniors", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Mundial de Clubes - São Paulo 1x0 Liverpool - Quem fez o gol?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Amoroso", IsCorrect = false },
                new() { Text = "Aloísio", IsCorrect = false },
                new() { Text = "Mineiro", IsCorrect = true },
                new() { Text = "Rogério Ceni", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem venceu a Bola de Ouro em 2018?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Messi", IsCorrect = false },
                new() { Text = "Cristiano Ronaldo", IsCorrect = false },
                new() { Text = "Luka Modrić", IsCorrect = true },
                new() { Text = "Mbappé", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual seleção venceu a Copa América de 2019?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Peru", IsCorrect = false },
                new() { Text = "Argentina", IsCorrect = false },
                new() { Text = "Brasil", IsCorrect = true },
                new() { Text = "Chile", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2018?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Boca Juniors", IsCorrect = false },
                    new AnswerOption { Text = "Flamengo", IsCorrect = false },
                    new AnswerOption { Text = "River Plate", IsCorrect = true },
                    new AnswerOption { Text = "Grêmio", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual foi o placar entre Real Madrid x Grêmio no Mundial de 2017?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "3x1", IsCorrect = false },
                    new AnswerOption { Text = "2x1", IsCorrect = false },
                    new AnswerOption { Text = "1x0", IsCorrect = true },
                    new AnswerOption { Text = "2x0", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual desses clubes Jonathan Calleri NÃO jogou?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "West Ham", IsCorrect = false },
                    new() { Text = "Osasuna", IsCorrect = false },
                    new() { Text = "Atalanta", IsCorrect = true },
                    new() { Text = "Las Palmas", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2021?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Flamengo", IsCorrect = false },
                new() { Text = "Palmeiras", IsCorrect = false },
                new() { Text = "Atlético-MG", IsCorrect = true },
                new() { Text = "Botafogo", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual desses clubes Maradona NÃO jogou?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Boca Juniors", IsCorrect = false },
                    new AnswerOption { Text = "Barcelona", IsCorrect = false },
                    new AnswerOption { Text = "Parma", IsCorrect = true },
                    new AnswerOption { Text = "Sevilla", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube foi campeão da Copa do Brasil em 2009?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Palmeiras", IsCorrect = false },
                    new AnswerOption { Text = "Internacional", IsCorrect = false },
                    new AnswerOption { Text = "Corinthians", IsCorrect = true },
                    new AnswerOption { Text = "Flamengo", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Mundial de Clubes - Liverpool 1x0 Flamengo - Quem fez o gol?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Salah", IsCorrect = false },
                new() { Text = "Sadio Mané", IsCorrect = false },
                new() { Text = "Roberto Firmino", IsCorrect = true },
                new() { Text = "Henderson", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem é o maior campeão da Copa da UEFA com 7 títulos?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Chelsea", IsCorrect = false },
                    new() { Text = "Tottenham", IsCorrect = false },
                    new() { Text = "Sevilla", IsCorrect = true },
                    new() { Text = "Juventus", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Na Era dos pontos corridos, qual jogador é o maior campeão do Brasileirão?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Dagoberto", IsCorrect = false },
                    new() { Text = "Everton Ribeiro", IsCorrect = false },
                    new() { Text = "Mayke", IsCorrect = true },
                    new() { Text = "Cássio", IsCorrect = false }
                }
            },

            // =========================
            // Q31–Q40 → CORRETA NA 4ª
            // =========================

            new Question
            {
                Text = "Qual clube venceu a Champions League de 2020?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "PSG", IsCorrect = false },
                new() { Text = "Barcelona", IsCorrect = false },
                new() { Text = "Manchester City", IsCorrect = false },
                new() { Text = "Bayern de Munique", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2022?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Internacional", IsCorrect = false },
                new() { Text = "Botafogo", IsCorrect = false },
                new() { Text = "Atlético-MG", IsCorrect = false },
                new() { Text = "Palmeiras", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2011?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Cruzeiro", IsCorrect = false },
                new() { Text = "Flamengo", IsCorrect = false },
                new() { Text = "Fluminense", IsCorrect = false },
                new() { Text = "Corinthians", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Mundial de Clubes - Internacional 1x0 Barcelona - Quem fez o gol?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Iarley", IsCorrect = false },
                new() { Text = "Luiz Adriano", IsCorrect = false },
                new() { Text = "Alexandre Pato", IsCorrect = false },
                new() { Text = "Adriano Gabiru", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Antes de ir para o Chelsea, Didier Drogba jogava em qual clube?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Barcelona", IsCorrect = false },
                new() { Text = "Le Mans", IsCorrect = false },
                new() { Text = "Galatasaray", IsCorrect = false },
                new() { Text = "Olympique de Marseille", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Quem marcou o gol do título da Copa de 2006?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Luca Toni", IsCorrect = false },
                new() { Text = "Del Piero", IsCorrect = false },
                new() { Text = "Pirlo", IsCorrect = false },
                new() { Text = "Grosso", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube é o maior campeão da Copa Libertadores?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "River Plate", IsCorrect = false },
                    new() { Text = "Boca Juniors", IsCorrect = false },
                    new() { Text = "Independiente", IsCorrect = true },
                    new() { Text = "Peñarol", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2015?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Atlético-MG", IsCorrect = false },
                new() { Text = "São Paulo", IsCorrect = false },
                new() { Text = "Grêmio", IsCorrect = false },
                new() { Text = "Corinthians", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual jogador detém o recorde de mais gols em uma única edição da Copa do Mundo?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Just Fontaine", IsCorrect = true },
                    new() { Text = "Ronaldo Fenômeno", IsCorrect = false },
                    new() { Text = "Miroslav Klose", IsCorrect = false },
                    new() { Text = "Pelé", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Em que ano foi introduzido oficialmente o cartão vermelho no futebol?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "1970", IsCorrect = true },
                    new() { Text = "1966", IsCorrect = false },
                    new() { Text = "1974", IsCorrect = false },
                    new() { Text = "1962", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual seleção venceu a Eurocopa de 2020?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Inglaterra", IsCorrect = false },
                    new() { Text = "Portugal", IsCorrect = false },
                    new() { Text = "França", IsCorrect = false },
                    new() { Text = "Itália", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube venceu o campeonato Brasileiro de 2019?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption> {
                new() { Text = "Santos", IsCorrect = false },
                new() { Text = "Grêmio", IsCorrect = false },
                new() { Text = "Palmeiras", IsCorrect = false },
                new() { Text = "Flamengo", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube detém o recorde de mais títulos consecutivos do Campeonato Brasileiro?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Cruzeiro", IsCorrect = false },
                    new() { Text = "Flamengo", IsCorrect = false },
                    new() { Text = "São Paulo", IsCorrect = true },
                    new() { Text = "Palmeiras", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a primeira edição da Premier League (1992–93)?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Manchester United", IsCorrect = true },
                    new() { Text = "Arsenal", IsCorrect = false },
                    new() { Text = "Liverpool", IsCorrect = false },
                    new() { Text = "Leeds United", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi o artilheiro da Copa do Mundo de 2010?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Thomas Müller", IsCorrect = true },
                    new() { Text = "David Villa", IsCorrect = false },
                    new() { Text = "Diego Forlán", IsCorrect = false },
                    new() { Text = "Sneijder", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual estádio sediou a final da Copa do Mundo de 1994?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "RFK Stadium", IsCorrect = false },
                    new() { Text = "MetLife Stadium", IsCorrect = false },
                    new() { Text = "Soldier Field", IsCorrect = false },
                    new() { Text = "Rose Bowl", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Liga dos Campeões da UEFA em 2006?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Arsenal", IsCorrect = false },
                    new() { Text = "Milan", IsCorrect = false },
                    new() { Text = "Villarreal", IsCorrect = false },
                    new() { Text = "Barcelona", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual técnico comandou o Brasil na Copa de 1990?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Carlos Alberto Parreira", IsCorrect = false },
                    new() { Text = "Telê Santana", IsCorrect = false },
                    new() { Text = "Sebastião Lazaroni", IsCorrect = true },
                    new() { Text = "Zagallo", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quantos títulos de Premier League o Guardiola já ganhou?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Cinco", IsCorrect = false },
                    new() { Text = "Seis", IsCorrect = true },
                    new() { Text = "Quatro", IsCorrect = false },
                    new() { Text = "Sete", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual temporada o Leicester City venceu a Premier League?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "2013-14", IsCorrect = false },
                    new() { Text = "2016-17", IsCorrect = false },
                    new() { Text = "2014-15", IsCorrect = false },
                    new() { Text = "2015-16", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube venceu a Libertadores de 2007?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "América do México", IsCorrect = false },
                    new AnswerOption { Text = "Grêmio", IsCorrect = false },
                    new AnswerOption { Text = "Internacional", IsCorrect = false },
                    new AnswerOption { Text = "Boca Juniors", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual clube revelou Diego Armando Maradona?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Boca Juniors", IsCorrect = false },
                    new AnswerOption { Text = "Newell's Old Boys", IsCorrect = false },
                    new AnswerOption { Text = "Racing", IsCorrect = false },
                    new AnswerOption { Text = "Argentinos Juniors", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Por qual seleção atuou Gheorghe Hagi?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Áustria", IsCorrect = false },
                    new AnswerOption { Text = "Hungria", IsCorrect = false },
                    new AnswerOption { Text = "Bulgária", IsCorrect = false },
                    new AnswerOption { Text = "Romênia", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual desses clubes David Beckham NÃO jogou?",
                ThemeId = themeId,
                Difficulty = DifficultyLevel.Hard,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Real Madrid", IsCorrect = false },
                    new() { Text = "Milan", IsCorrect = false },
                    new() { Text = "PSG", IsCorrect = false },
                    new() { Text = "Inter de Milão", IsCorrect = true }
                }
            }

        );
    }

}
