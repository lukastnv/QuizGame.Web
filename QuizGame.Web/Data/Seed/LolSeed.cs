using QuizGame.Web.Data;
using QuizGame.Web.Models;

public static class LolSeed
{
    public static void Seed(QuizDbContext context)
    {
        var lol = context.Themes.First(t => t.Name == "League of Legends");

        // Evita duplicar perguntas
        if (context.Questions.Any(q => q.ThemeId == lol.Id))
            return;

        context.Questions.AddRange(

            new Question
            {
                Text = "Qual campeão é conhecido como o Criador das Estrelas?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Aurelion Sol", IsCorrect = true },
                    new() { Text = "Bardo", IsCorrect = false },
                    new() { Text = "Zoe", IsCorrect = false },
                    new() { Text = "Pantheon", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe tem o maior número de títulos do CBLOL?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "INTZ", IsCorrect = true },
                    new() { Text = "LOUD", IsCorrect = false },
                    new() { Text = "KaBuM!", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador é o maior campeão do CBLOL?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Tockers", IsCorrect = false },
                    new() { Text = "Tinowns", IsCorrect = false },
                    new() { Text = "Robo", IsCorrect = true },
                    new() { Text = "brTT", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual foi a primeira equipe campeã do campeonato brasileiro?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "vTi Nox", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "CNB e-Sports", IsCorrect = false },
                    new() { Text = "vTi Ignis", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual dessas equipes brTT nunca jogou?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Keyd Stars", IsCorrect = false },
                    new() { Text = "CNB e-Sports", IsCorrect = true },
                    new() { Text = "Red Canids", IsCorrect = false },
                    new() { Text = "Los Grandes", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Em que ano aconteceu o primeiro Worlds?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "2010", IsCorrect = false },
                    new() { Text = "2011", IsCorrect = true },
                    new() { Text = "2012", IsCorrect = false },
                    new() { Text = "2013", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o primeiro Worlds?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "TSM", IsCorrect = false },
                    new() { Text = "SK Telecom T1", IsCorrect = false },
                    new() { Text = "Fnatic", IsCorrect = true },
                    new() { Text = "Taipei Assassins", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2012?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Azubu Frost", IsCorrect = false },
                    new() { Text = "SK Telecom T1", IsCorrect = false },
                    new() { Text = "Moscow Five", IsCorrect = false },
                    new() { Text = "Taipei Assassins", IsCorrect = true }
                }
            }, 
            
            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2013?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "SK Telecom T1", IsCorrect = true },
                    new() { Text = "Royal Club", IsCorrect = false },
                    new() { Text = "Najin Black Sword", IsCorrect = false },
                    new() { Text = "Fnatic", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2014?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Star Horn Royal Club", IsCorrect = false },
                    new() { Text = "Samsung White", IsCorrect = true },
                    new() { Text = "SK Telecom T1", IsCorrect = false },
                    new() { Text = "Samsung Blue", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2015?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Fnatic", IsCorrect = false },
                    new() { Text = "KOO Tigers", IsCorrect = false },
                    new() { Text = "SK Telecom T1", IsCorrect = true },
                    new() { Text = "paiN Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2016?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Cloud9", IsCorrect = false },
                    new() { Text = "ROX Tigers", IsCorrect = false },
                    new() { Text = "Samsung Galaxy", IsCorrect = false },
                    new() { Text = "SK Telecom T1", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2017?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Samsung Galaxy", IsCorrect = true },
                    new() { Text = "SK Telecom T1", IsCorrect = false },
                    new() { Text = "RNG", IsCorrect = false },
                    new() { Text = "Edward Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2018?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Fnatic", IsCorrect = false },
                    new() { Text = "Invictus Gaming", IsCorrect = true },
                    new() { Text = "G2 Esports", IsCorrect = false },
                    new() { Text = "Cloud9", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2019?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "SK Telecom T1", IsCorrect = false },
                    new() { Text = "Invictus Gaming", IsCorrect = false },
                    new() { Text = "FunPlus Phoenix", IsCorrect = true },
                    new() { Text = "G2 Esports", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2020?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "SK Telecom T1", IsCorrect = false },
                    new() { Text = "Top Esports", IsCorrect = false },
                    new() { Text = "Suning", IsCorrect = false },
                    new() { Text = "DAMWON", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2021?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Edward Gaming", IsCorrect = true },
                    new() { Text = "T1", IsCorrect = false },
                    new() { Text = "Gen.G", IsCorrect = false },
                    new() { Text = "DAMWON Kia", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2022?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "T1", IsCorrect = false },
                    new() { Text = "DRX", IsCorrect = true },
                    new() { Text = "Gen.G", IsCorrect = false },
                    new() { Text = "JD Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2023?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Bilibili Gaming", IsCorrect = false },
                    new() { Text = "DRX", IsCorrect = false },
                    new() { Text = "T1", IsCorrect = true },
                    new() { Text = "JD Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2024?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Bilibili Gaming", IsCorrect = false },
                    new() { Text = "Gen.G", IsCorrect = false },
                    new() { Text = "Weibo Gaming", IsCorrect = false },
                    new() { Text = "T1", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o Worlds 2025?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "T1", IsCorrect = true },
                    new() { Text = "KT Rolster", IsCorrect = false },
                    new() { Text = "Gen.G", IsCorrect = false },
                    new() { Text = "Top Esports", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Em que ano aconteceu o primeiro MSI?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "2014", IsCorrect = false },
                    new() { Text = "2015", IsCorrect = true },
                    new() { Text = "2016", IsCorrect = false },
                    new() { Text = "2017", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o primeiro MSI?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Fnatic", IsCorrect = false },
                    new() { Text = "SK Telecom T1", IsCorrect = false },
                    new() { Text = "Edward Gaming", IsCorrect = true },
                    new() { Text = "TSM", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o MSI 2016?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "RNG", IsCorrect = false },
                    new() { Text = "CLG", IsCorrect = false },
                    new() { Text = "Flash Wolves", IsCorrect = false },
                    new() { Text = "SK Telecom T1", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o MSI 2017?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "SK Telecom T1", IsCorrect = true },
                    new() { Text = "G2 Esports", IsCorrect = false },
                    new() { Text = "Flash Wolves", IsCorrect = false },
                    new() { Text = "Team WE", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o MSI 2018?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "SK Telecom T1", IsCorrect = false },
                    new() { Text = "RNG", IsCorrect = true },
                    new() { Text = "Fnatic", IsCorrect = false },
                    new() { Text = "Kingzone DragonX", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o MSI 2019?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Invictus Gaming", IsCorrect = false },
                    new() { Text = "SK Telecom T1", IsCorrect = false },
                    new() { Text = "G2 Esports", IsCorrect = true },
                    new() { Text = "Team Liquid", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o MSI 2021?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "PSG Talon", IsCorrect = false },
                    new() { Text = "T1", IsCorrect = false },
                    new() { Text = "DAMWON Kia", IsCorrect = false },
                    new() { Text = "RNG", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o MSI 2022?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "RNG", IsCorrect = true },
                    new() { Text = "T1", IsCorrect = false },
                    new() { Text = "G2 Esports", IsCorrect = false },
                    new() { Text = "Gen.G", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o MSI 2023?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Bilibili Gaming", IsCorrect = false },
                    new() { Text = "JD Gaming", IsCorrect = true },
                    new() { Text = "T1", IsCorrect = false },
                    new() { Text = "Gen.G", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o MSI 2024?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "T1", IsCorrect = false },
                    new() { Text = "Bilibili Gaming", IsCorrect = false },
                    new() { Text = "Gen.G", IsCorrect = true },
                    new() { Text = "G2 Esports", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o MSI 2025?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Anyone's Legend", IsCorrect = false },
                    new() { Text = "T1", IsCorrect = false },
                    new() { Text = "Bilibili Gaming", IsCorrect = false },
                    new() { Text = "Gen.G", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual é o jogador com mais títulos de Worlds?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Faker", IsCorrect = true },
                    new() { Text = "Uzi", IsCorrect = false },
                    new() { Text = "Bengi", IsCorrect = false },
                    new() { Text = "Keria", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual é o jogador com mais títulos de MSI?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Gala", IsCorrect = false },
                    new() { Text = "Xiaohu", IsCorrect = true },
                    new() { Text = "Faker", IsCorrect = false },
                    new() { Text = "Chovy", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual é a equipe com mais títulos de MSI?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Edward Gaming", IsCorrect = false },
                    new() { Text = "T1 (SK Telecom T1)", IsCorrect = false },
                    new() { Text = "Royal Never Give Up (RNG)", IsCorrect = true },
                    new() { Text = "Gen.G", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2014?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "PawN", IsCorrect = false },
                    new() { Text = "Dandy", IsCorrect = false },
                    new() { Text = "Faker", IsCorrect = false },
                    new() { Text = "Mata", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2015?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "MaRin", IsCorrect = true },
                    new() { Text = "Bengi", IsCorrect = false },
                    new() { Text = "Faker", IsCorrect = false },
                    new() { Text = "Smeb", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2016?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Ruler", IsCorrect = false },
                    new() { Text = "Faker", IsCorrect = true },
                    new() { Text = "Bang", IsCorrect = false },
                    new() { Text = "Wolf", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2017?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Crown", IsCorrect = false },
                    new() { Text = "Peanut", IsCorrect = false },
                    new() { Text = "Ruler", IsCorrect = true },
                    new() { Text = "Faker", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2018?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Caps", IsCorrect = false },
                    new() { Text = "TheShy", IsCorrect = false },
                    new() { Text = "Rookie", IsCorrect = false },
                    new() { Text = "Ning", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2019?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Tian", IsCorrect = true },
                    new() { Text = "Doinb", IsCorrect = false },
                    new() { Text = "Caps", IsCorrect = false },
                    new() { Text = "Faker", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2020?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "ShowMaker", IsCorrect = false },
                    new() { Text = "Canyon", IsCorrect = true },
                    new() { Text = "Nuguri", IsCorrect = false },
                    new() { Text = "Bin", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2021?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Khan", IsCorrect = false },
                    new() { Text = "Canyon", IsCorrect = false },
                    new() { Text = "Scout", IsCorrect = true },
                    new() { Text = "Viper", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2022?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Keria", IsCorrect = false },
                    new() { Text = "Faker", IsCorrect = false },
                    new() { Text = "Deft", IsCorrect = false },
                    new() { Text = "Kingen", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2023?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Zeus", IsCorrect = true },
                    new() { Text = "Faker", IsCorrect = false },
                    new() { Text = "Keria", IsCorrect = false },
                    new() { Text = "Oner", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2024?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Keria", IsCorrect = false },
                    new() { Text = "Faker", IsCorrect = true },
                    new() { Text = "Zeus", IsCorrect = false },
                    new() { Text = "Gumayusi", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador foi o MVP do Worlds 2025?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Keria", IsCorrect = false },
                    new() { Text = "Faker", IsCorrect = false },
                    new() { Text = "Gumayusi", IsCorrect = true },
                    new() { Text = "Oner", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual time chinês foi o primeiro a vencer um Worlds?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Royal Never Give Up", IsCorrect = false },
                    new() { Text = "Edward Gaming", IsCorrect = false },
                    new() { Text = "Invictus Gaming", IsCorrect = true },
                    new() { Text = "FunPlus Phoenix", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi o Campeão Brasileiro de 2013?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Nex Impetus", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = true },
                    new() { Text = "CNB", IsCorrect = false },
                    new() { Text = "Keyd Team", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2014?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "KaBuM!", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "Keyd Stars", IsCorrect = true },
                    new() { Text = "CNB", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2014?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "Keyd Stars", IsCorrect = false },
                    new() { Text = "CNB", IsCorrect = false },
                    new() { Text = "KaBuM!", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2015?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "INTZ", IsCorrect = true },
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "Keyd Stars", IsCorrect = false },
                    new() { Text = "CNB", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2015?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Keyd Stars", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = true },
                    new() { Text = "CNB", IsCorrect = false },
                    new() { Text = "INTZ", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2016?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Keyd Stars", IsCorrect = false },
                    new() { Text = "Operation Kino", IsCorrect = false },
                    new() { Text = "INTZ", IsCorrect = true },
                    new() { Text = "KaBuM!", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2016?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Keyd Stars", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "CNB", IsCorrect = false },
                    new() { Text = "INTZ", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2017?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "RED Canids", IsCorrect = true },
                    new() { Text = "Key Stars", IsCorrect = false },
                    new() { Text = "INTZ", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2017?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "Team oNe", IsCorrect = true },
                    new() { Text = "RED Canids", IsCorrect = false },
                    new() { Text = "INTZ", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2018?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Vivo Keyd", IsCorrect = false },
                    new() { Text = "RED Canids", IsCorrect = false },
                    new() { Text = "KaBuM!", IsCorrect = true },
                    new() { Text = "CNB", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2018?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Flamengo", IsCorrect = false },
                    new() { Text = "CNB", IsCorrect = false },
                    new() { Text = "Vivo Keyd", IsCorrect = false },
                    new() { Text = "KaBuM!", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2019?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "INTZ", IsCorrect = true },
                    new() { Text = "Flamengo", IsCorrect = false },
                    new() { Text = "Redemption", IsCorrect = false },
                    new() { Text = "CNB", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2019?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "INTZ", IsCorrect = false },
                    new() { Text = "Flamengo", IsCorrect = true },
                    new() { Text = "Uppercut", IsCorrect = false },
                    new() { Text = "KaBuM!", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2020?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Vivo Keyd", IsCorrect = false },
                    new() { Text = "Flamengo", IsCorrect = false },
                    new() { Text = "KaBuM!", IsCorrect = true },
                    new() { Text = "Furia", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2020?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "KaBuM!", IsCorrect = false },
                    new() { Text = "PRG", IsCorrect = false },
                    new() { Text = "INTZ!", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2021?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "paiN Gaming", IsCorrect = true },
                    new() { Text = "Vorax", IsCorrect = false },
                    new() { Text = "Flamengo", IsCorrect = false },
                    new() { Text = "RED Canids", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2021?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Rensga", IsCorrect = false },
                    new() { Text = "RED Canids", IsCorrect = true },
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "Vorax", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2022?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "LOUD", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "RED Canids", IsCorrect = true },
                    new() { Text = "Furia", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2022?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Furia", IsCorrect = false },
                    new() { Text = "RED Canids", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "LOUD", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2023?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "LOUD", IsCorrect = true },
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "Furia", IsCorrect = false },
                    new() { Text = "LOS Grandes", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2023?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "INTZ", IsCorrect = false },
                    new() { Text = "LOUD", IsCorrect = true },
                    new() { Text = "paiN Gaming", IsCorrect = false },
                    new() { Text = "RED Canids", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 1 de 2024?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "RED Canids", IsCorrect = false },
                    new() { Text = "Vivo Keyd Stars", IsCorrect = false },
                    new() { Text = "LOUD", IsCorrect = true },
                    new() { Text = "paiN Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou o CBLOL Split 2 de 2024?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "RED Canids", IsCorrect = false },
                    new() { Text = "LOUD", IsCorrect = false },
                    new() { Text = "Vivo Keyd Stars", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou a LTA South(CBLOL) Split 2 de 2025?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Vivo Keyd Stars", IsCorrect = false },
                    new() { Text = "Furia", IsCorrect = true },
                    new() { Text = "Isurus Estral", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ganhou a LTA South(CBLOL) Split 3 de 2025?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "LOUD", IsCorrect = false },
                    new() { Text = "RED Canids", IsCorrect = false },
                    new() { Text = "Vivo Keyd Stars", IsCorrect = true },
                    new() { Text = "paiN Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual dessas equipes representou o Brasil no Worlds 2015?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "KaBuM! e-Sports", IsCorrect = false },
                    new() { Text = "Keyd Stars", IsCorrect = false },
                    new() { Text = "INTZ", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual dessas equipes representou o Brasil no Worlds 2025?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Vivo Keyd Stars", IsCorrect = true },
                    new() { Text = "Furia", IsCorrect = false },
                    new() { Text = "LOUD", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual dessas equipes representou o Brasil no MSI 2025?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Vivo Keyd Stars", IsCorrect = false },
                    new() { Text = "Furia", IsCorrect = true },
                    new() { Text = "LOUD", IsCorrect = false },
                    new() { Text = "paiN Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quantos títulos do CBLOL o brTT tem?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Quatro", IsCorrect = false },
                    new() { Text = "Cinco", IsCorrect = false },
                    new() { Text = "Seis", IsCorrect = true },
                    new() { Text = "Sete", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quantos títulos do CBLOL o Tinowns tem?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Quatro", IsCorrect = false },
                    new() { Text = "Cinco", IsCorrect = false },
                    new() { Text = "Seis", IsCorrect = true },
                    new() { Text = "Sete", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quantos títulos do CBLOL o Tockers tem?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Três", IsCorrect = false },
                    new() { Text = "Quatro", IsCorrect = true },
                    new() { Text = "Cinco", IsCorrect = false },
                    new() { Text = "Seis", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quantos títulos do CBLOL o Kami tem?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Dois", IsCorrect = true },
                    new() { Text = "Três", IsCorrect = false },
                    new() { Text = "Quatro", IsCorrect = false },
                    new() { Text = "Cinco", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quantos títulos do CBLOL o Revolta tem?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Dois", IsCorrect = false },
                    new() { Text = "Três", IsCorrect = true },
                    new() { Text = "Quatro", IsCorrect = false },
                    new() { Text = "Cinco", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Em que ano a pain Gaming foi rebaixada para o Circuito Desafiante?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "2016", IsCorrect = false },
                    new() { Text = "2017", IsCorrect = false },
                    new() { Text = "2018", IsCorrect = true },
                    new() { Text = "2019", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quantos títulos do CBLOL a paiN Gaming tem?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Três", IsCorrect = false },
                    new() { Text = "Quatro", IsCorrect = true },
                    new() { Text = "Cinco", IsCorrect = false },
                    new() { Text = "Seis", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quantos títulos do CBLOL a LOUD tem?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Três", IsCorrect = false },
                    new() { Text = "Quatro", IsCorrect = true },
                    new() { Text = "Cinco", IsCorrect = false },
                    new() { Text = "Seis", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Complete a frase: Kami, você não sabe jogar de ...",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Cassiopeia", IsCorrect = false },
                    new() { Text = "Kassadin", IsCorrect = false },
                    new() { Text = "Katarina", IsCorrect = true },
                    new() { Text = "Orianna", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quantos títulos de LCK o Chovy tem?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Três", IsCorrect = false },
                    new() { Text = "Quatro", IsCorrect = false },
                    new() { Text = "Cinco", IsCorrect = true },
                    new() { Text = "Seis", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual desses jogadores NÃO estava no elenco da paiN 2015?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "SirT", IsCorrect = false },
                    new() { Text = "Dioud", IsCorrect = false },
                    new() { Text = "Mylon", IsCorrect = false },
                    new() { Text = "Loop", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual é o valor de AP flat do item Capuz da Morte de Rabadon",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "110", IsCorrect = false },
                    new() { Text = "120", IsCorrect = false },
                    new() { Text = "130", IsCorrect = true },
                    new() { Text = "140", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual é o valor de Dano de Ataque do item novo Quebra-Bastião?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "50", IsCorrect = false },
                    new() { Text = "55", IsCorrect = true },
                    new() { Text = "60", IsCorrect = false },
                    new() { Text = "65", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quanto de gold custa no total o item Força da Trindade?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "3333", IsCorrect = true },
                    new() { Text = "3000", IsCorrect = false },
                    new() { Text = "3300", IsCorrect = false },
                    new() { Text = "3330", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual campeão é o dono original da Espada do Rei Destruído?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Yasuo", IsCorrect = false },
                    new() { Text = "Master Yi", IsCorrect = false },
                    new() { Text = "Garen", IsCorrect = false },
                    new() { Text = "Viego", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual campeão foi o responsável direto pela Ruína das Ilhas das Sombras?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Thresh", IsCorrect = false },
                    new() { Text = "Yorick", IsCorrect = false },
                    new() { Text = "Viego", IsCorrect = true },
                    new() { Text = "Hecarim", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual campeão é um Darkin aprisionado dentro de uma espada?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Yone", IsCorrect = false },
                    new() { Text = "Aatrox", IsCorrect = true },
                    new() { Text = "Riven", IsCorrect = false },
                    new() { Text = "Tryndamere", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem é a Imperatriz do Void?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Bel'Veth", IsCorrect = true },
                    new() { Text = "Rek'Sai", IsCorrect = false },
                    new() { Text = "Vel'Koz", IsCorrect = false },
                    new() { Text = "Cho'Gath", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem é a Imperatriz do Void?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Bel'Veth", IsCorrect = true },
                    new() { Text = "Rek'Sai", IsCorrect = false },
                    new() { Text = "Vel'Koz", IsCorrect = false },
                    new() { Text = "Cho'Gath", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual campeão é o Aspecto do Sol?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Diana", IsCorrect = false },
                    new() { Text = "Leona", IsCorrect = true },
                    new() { Text = "Pantheon", IsCorrect = false },
                    new() { Text = "Taric", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual campeão representa o ideal de força acima da moral em Noxus?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Katarina", IsCorrect = false },
                    new() { Text = "Swain", IsCorrect = false },
                    new() { Text = "Talon", IsCorrect = false },
                    new() { Text = "Darius", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Quem lidera Noxus atualmente na lore?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "LeBlanc", IsCorrect = false },
                    new() { Text = "Darius", IsCorrect = false },
                    new() { Text = "Mordekaiser", IsCorrect = false },
                    new() { Text = "Swain", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "O que Yone se tornou após sua morte?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Um espírito vingativo", IsCorrect = false },
                    new() { Text = "Um caçador de azakana", IsCorrect = true },
                    new() { Text = "Um Darkin", IsCorrect = false },
                    new() { Text = "Um Aspecto", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual foi o crime pelo qual Yasuo foi inicialmente acusado?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Traição a Ionia", IsCorrect = false },
                    new() { Text = "Assassinato de um mestre ioniano", IsCorrect = false },
                    new() { Text = "Matar o Ancião Souma", IsCorrect = true },
                    new() { Text = "Usar magia proibida", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual a relação entre Yasuo e Yone?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Mestre e aprendiz", IsCorrect = false },
                    new() { Text = "Rivais de clã", IsCorrect = false },
                    new() { Text = "Primos", IsCorrect = false },
                    new() { Text = "Irmaõs", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "O que torna o estilo de combate de Irelia único?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Lâminas dançantes controladas por dança", IsCorrect = true },
                    new() { Text = "Magia elemental", IsCorrect = false },
                    new() { Text = "Espadas amaldiçoadas", IsCorrect = false },
                    new() { Text = "Tecnologia hextec", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual é o principal objetivo de Lucian?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Destruir o Void", IsCorrect = false },
                    new() { Text = "Libertar Senna da Névoa Negra", IsCorrect = true },
                    new() { Text = "Vingar sua família", IsCorrect = false },
                    new() { Text = "Governar Demacia", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem aprisionou Senna na lanterna?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Hecarim", IsCorrect = false },
                    new() { Text = "Viego", IsCorrect = false },
                    new() { Text = "Kalista", IsCorrect = false },
                    new() { Text = "Thresh", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Quem foi o mentor de Wukong?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Master Yi", IsCorrect = true },
                    new() { Text = "Shen", IsCorrect = false },
                    new() { Text = "Zed", IsCorrect = false },
                    new() { Text = "Lee sin", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem adotou Talon e o treinou como assassino?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Swain", IsCorrect = false },
                    new() { Text = "Katarina", IsCorrect = false },
                    new() { Text = "General Du Couteau", IsCorrect = true },
                    new() { Text = "Darius", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem é o maior rival ideológico de Zed em Ionia?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Akali", IsCorrect = false },
                    new() { Text = "Shen", IsCorrect = true },
                    new() { Text = "Kennen", IsCorrect = false },
                    new() { Text = "Lee sin", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual é a relação entre Kayle e Morgana?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Rivais escolhidas", IsCorrect = false },
                    new() { Text = "Mestre e aprendiz", IsCorrect = false },
                    new() { Text = "Antigas aliadas", IsCorrect = false },
                    new() { Text = "Irmãs", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "De quem é a frase: A lâmina que não se vê é a mais mortífera.",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Talon", IsCorrect = false },
                    new() { Text = "Shen", IsCorrect = false },
                    new() { Text = "Zed", IsCorrect = true },
                    new() { Text = "Yone", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "De quem é a frase: A morte é como o vento… está sempre ao meu lado.",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Yasuo", IsCorrect = true },
                    new() { Text = "Yone", IsCorrect = false },
                    new() { Text = "Irelia", IsCorrect = false },
                    new() { Text = "Master Yi", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "De quem é a frase: Todo monstro que eu caço me aproxima dela.",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Yorick", IsCorrect = false },
                    new() { Text = "Lucian", IsCorrect = true },
                    new() { Text = "Garen", IsCorrect = false },
                    new() { Text = "Viego", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "De quem é a frase: Não existe redenção. Apenas julgamento.",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Morgana", IsCorrect = false },
                    new() { Text = "Aatrox", IsCorrect = false },
                    new() { Text = "Kayle", IsCorrect = true },
                    new() { Text = "Pantheon", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "De quem é a frase: Todos morrem… alguns só precisam de ajuda.",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Darius", IsCorrect = false },
                    new() { Text = "Talon", IsCorrect = false },
                    new() { Text = "Pyke", IsCorrect = false },
                    new() { Text = "Zed", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "De quem é a frase: Eu não busco redenção.",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Sylas", IsCorrect = true },
                    new() { Text = "Kayle", IsCorrect = false },
                    new() { Text = "Viego", IsCorrect = false },
                    new() { Text = "Pantheon", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "De quem é a frase: O poder exige sacrifício.",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Ryze", IsCorrect = false },
                    new() { Text = "Swain", IsCorrect = true },
                    new() { Text = "Viktor", IsCorrect = false },
                    new() { Text = "Mordekaiser", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "De quem é a frase: Mira, respira… mata.",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Samira", IsCorrect = false },
                    new() { Text = "Jhin", IsCorrect = false },
                    new() { Text = "Caitlyn", IsCorrect = true },
                    new() { Text = "Aphelios", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "De quem é a frase: Mira, respira… mata.",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Samira", IsCorrect = false },
                    new() { Text = "Jhin", IsCorrect = false },
                    new() { Text = "Caitlyn", IsCorrect = false },
                    new() { Text = "Aphelios", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "De quem é a frase: Unam-se à gloriosa evolução.",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Viktor", IsCorrect = true },
                    new() { Text = "Singed", IsCorrect = false },
                    new() { Text = "Heimerdinger", IsCorrect = false },
                    new() { Text = "Jayce", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "De quem é a frase: Regras foram feitas pra ser quebradas!",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Vi", IsCorrect = false },
                    new() { Text = "Jinx", IsCorrect = true },
                    new() { Text = "Ziggs", IsCorrect = false },
                    new() { Text = "Ekko", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "De quem é a frase: Se acha esperto, não é mesmo?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Syndra", IsCorrect = false },
                    new() { Text = "LeBlanc", IsCorrect = false },
                    new() { Text = "Ahri", IsCorrect = true },
                    new() { Text = "Katarina", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "De quem é a frase: Agora você me vê, agora você não vê!",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Pyke", IsCorrect = false },
                    new() { Text = "Akali", IsCorrect = false },
                    new() { Text = "Zed", IsCorrect = false },
                    new() { Text = "Shaco", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Quanto custa o item Espada G.P.C.?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "1300", IsCorrect = true },
                    new() { Text = "1200", IsCorrect = false },
                    new() { Text = "1100", IsCorrect = false },
                    new() { Text = "1400", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quanto custa o item Punhal Serrilhado?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "900", IsCorrect = false },
                    new() { Text = "1000", IsCorrect = true },
                    new() { Text = "1100", IsCorrect = false },
                    new() { Text = "1200", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quanto custa o item Brutalizador?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "1300", IsCorrect = false },
                    new() { Text = "1330", IsCorrect = false },
                    new() { Text = "1337", IsCorrect = true },
                    new() { Text = "1333", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quanto custa o item Flechatroz de Yun Tal?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "2900", IsCorrect = false },
                    new() { Text = "3000", IsCorrect = false },
                    new() { Text = "3200", IsCorrect = false },
                    new() { Text = "3100", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Quanto custa o item Gume do Infinito?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "3500", IsCorrect = true },
                    new() { Text = "3300", IsCorrect = false },
                    new() { Text = "3600", IsCorrect = false },
                    new() { Text = "3400", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "A passiva do item Capuz da Morte de Rabadon aumenta o AP em?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "25%", IsCorrect = false },
                    new() { Text = "30%", IsCorrect = true },
                    new() { Text = "35%", IsCorrect = false },
                    new() { Text = "40%", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual o nome da Ultimate da Caitlyn?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Rede calibre 90", IsCorrect = false },
                    new() { Text = "Bem na mira", IsCorrect = false },
                    new() { Text = "Ás na manga", IsCorrect = true },
                    new() { Text = "Pacificadora de Piltover", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual o nome da Ultimate do Zed?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Corte sombrio", IsCorrect = false },
                    new() { Text = "Sombra viva", IsCorrect = false },
                    new() { Text = "Desprezo pelos fracos", IsCorrect = false },
                    new() { Text = "Marca Fatal", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual o nome da Ultimate da Ahri?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Ímpeto espiritual", IsCorrect = true },
                    new() { Text = "Fogo de raposa", IsCorrect = false },
                    new() { Text = "Furto de essência", IsCorrect = false },
                    new() { Text = "Orbe da ilusão", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual o nome da Ultimate do Yasuo?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Tempestade de aço", IsCorrect = false },
                    new() { Text = "Último suspiro", IsCorrect = true },
                    new() { Text = "Espada ágil", IsCorrect = false },
                    new() { Text = "Estilo do errante", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual o nome da habilidade Q do Volibear?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Emissário da tempestade", IsCorrect = false },
                    new() { Text = "Fúria selvagem", IsCorrect = false },
                    new() { Text = "Esmagamento trovejante", IsCorrect = true },
                    new() { Text = "Divisor de céus", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Furia do dragão é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Shyvana", IsCorrect = false },
                    new() { Text = "Udyr", IsCorrect = false },
                    new() { Text = "Smolder", IsCorrect = false },
                    new() { Text = "Lee sin", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Reta da morte é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Draven", IsCorrect = true },
                    new() { Text = "Pantheon", IsCorrect = false },
                    new() { Text = "Jhin", IsCorrect = false },
                    new() { Text = "Kled", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Hora do show é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Wukong", IsCorrect = false },
                    new() { Text = "Sett", IsCorrect = true },
                    new() { Text = "Ekko", IsCorrect = false },
                    new() { Text = "Rakan", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Portal de reinos é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Shen", IsCorrect = false },
                    new() { Text = "Xerath", IsCorrect = false },
                    new() { Text = "Sylas", IsCorrect = false },
                    new() { Text = "Ryze", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Encantador de raízes é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Ivern", IsCorrect = true },
                    new() { Text = "Maokai", IsCorrect = false },
                    new() { Text = "Malphite", IsCorrect = false },
                    new() { Text = "Trundle", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Força incontrolável é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Tryndamere", IsCorrect = false },
                    new() { Text = "Malphite", IsCorrect = true },
                    new() { Text = "Renekton", IsCorrect = false },
                    new() { Text = "Gragas", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Carga de profundidade é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Corki", IsCorrect = false },
                    new() { Text = "Gangplank", IsCorrect = false },
                    new() { Text = "Nautilus", IsCorrect = true },
                    new() { Text = "Rumble", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Esfera negra é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Malzahar", IsCorrect = false },
                    new() { Text = "Morgana", IsCorrect = false },
                    new() { Text = "Orianna", IsCorrect = false },
                    new() { Text = "Syndra", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Reino da morte é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Mordekaiser", IsCorrect = true },
                    new() { Text = "Viego", IsCorrect = false },
                    new() { Text = "Hecarim", IsCorrect = false },
                    new() { Text = "Swain", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Surto da lâmina é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Talon", IsCorrect = false },
                    new() { Text = "Irelia", IsCorrect = true },
                    new() { Text = "Yone", IsCorrect = false },
                    new() { Text = "Fiora", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Surto da lâmina é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Talon", IsCorrect = false },
                    new() { Text = "Irelia", IsCorrect = true },
                    new() { Text = "Yone", IsCorrect = false },
                    new() { Text = "Katarina", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Maré violenta é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Nautilus", IsCorrect = false },
                    new() { Text = "Fizz", IsCorrect = false },
                    new() { Text = "Nami", IsCorrect = true },
                    new() { Text = "Illaoi", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Luz perfurante é uma habilidade de qual campeão?",
                ThemeId = lol.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new() { Text = "Leona", IsCorrect = false },
                    new() { Text = "Kayle", IsCorrect = false },
                    new() { Text = "Lux", IsCorrect = false },
                    new() { Text = "Lucian", IsCorrect = true }
                }
            }

        );

        context.SaveChanges();
    }
}
