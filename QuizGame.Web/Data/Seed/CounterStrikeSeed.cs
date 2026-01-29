using QuizGame.Web.Data;
using QuizGame.Web.Models;

public static class CounterStrikeSeed
{
    public static void Seed(QuizDbContext context)
    {
        var cs = context.Themes.First(t => t.Name == "Counter Strike");

        if (context.Questions.Any(q => q.ThemeId == cs.Id))
            return;

        var questions = new List<Question>
        {
            new Question
        {
            Text = "Qual país venceu o primeiro Major de CS:GO (DreamHack Winter 2013)?",
            ThemeId = cs.Id,
            AnswerOptions = new List<AnswerOption>
            {
                new AnswerOption { Text = "Suécia", IsCorrect = true },
                new AnswerOption { Text = "Brasil", IsCorrect = false },
                new AnswerOption { Text = "Dinamarca", IsCorrect = false },
                new AnswerOption { Text = "França", IsCorrect = false }
            }
        },

            new Question
            {
                Text = "Qual organização é conhecida como a maior campeã de Majors de CS:GO?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Fnatic", IsCorrect = false },
                    new AnswerOption { Text = "Astralis", IsCorrect = true },
                    new AnswerOption { Text = "NAVI", IsCorrect = false },
                    new AnswerOption { Text = "SK Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador é conhecido pelo apelido 's1mple'?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Mathieu Herbaut", IsCorrect = false },
                    new AnswerOption { Text = "Nicolai Reedtz", IsCorrect = false },
                    new AnswerOption { Text = "Oleksandr Kostyliev", IsCorrect = true },
                    new AnswerOption { Text = "Gabriel Toledo", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe venceu o PGL Major Stockholm 2021?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Gambit", IsCorrect = false },
                    new AnswerOption { Text = "G2 Esports", IsCorrect = false },
                    new AnswerOption { Text = "Heroic", IsCorrect = false },
                    new AnswerOption { Text = "Natus Vincere", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual jogador brasileiro é conhecido pelo nick 'FalleN'?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Gabriel Toledo", IsCorrect = true },
                    new AnswerOption { Text = "Fernando Alvarenga", IsCorrect = false },
                    new AnswerOption { Text = "Epitácio Pessoa", IsCorrect = false },
                    new AnswerOption { Text = "Marcelo David", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual função é responsável por liderar taticamente a equipe?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "AWPer", IsCorrect = false },
                    new AnswerOption { Text = "IGL", IsCorrect = true },
                    new AnswerOption { Text = "Entry Fragger", IsCorrect = false },
                    new AnswerOption { Text = "Support", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual dessas armas é exclusiva do lado TR?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "AUG", IsCorrect = false },
                    new AnswerOption { Text = "M4A4", IsCorrect = false },
                    new AnswerOption { Text = "AK-47", IsCorrect = true },
                    new AnswerOption { Text = "FAMAS", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual time venceu o IEM Katowice 2019?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Team Liquid", IsCorrect = false },
                    new AnswerOption { Text = "Astralis", IsCorrect = true },
                    new AnswerOption { Text = "ENCE", IsCorrect = false },
                    new AnswerOption { Text = "FaZe Clan", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador ficou famoso pelo clutch '1v4' no mapa Overpass pela Fnatic?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "JW", IsCorrect = false },
                    new AnswerOption { Text = "KRIMZ", IsCorrect = false },
                    new AnswerOption { Text = "flusha", IsCorrect = true },
                    new AnswerOption { Text = "olofmeister", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual organização ficou invicta durante todo o ano de 2018 em Majors?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Fnatic", IsCorrect = false },
                    new AnswerOption { Text = "Natus Vincere", IsCorrect = false },
                    new AnswerOption { Text = "Astralis", IsCorrect = true },
                    new AnswerOption { Text = "SK Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador é conhecido como o melhor rifler da história do CS:GO?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "NiKo", IsCorrect = true },
                    new AnswerOption { Text = "s1mple", IsCorrect = false },
                    new AnswerOption { Text = "coldzera", IsCorrect = false },
                    new AnswerOption { Text = "device", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual time brasileiro venceu o Major MLG Columbus 2016?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "SK Gaming", IsCorrect = false },
                    new AnswerOption { Text = "Luminosity Gaming", IsCorrect = true },
                    new AnswerOption { Text = "MIBR", IsCorrect = false },
                    new AnswerOption { Text = "FURIA", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual mapa ficou conhecido como o 'mapa da Astralis'?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Nuke", IsCorrect = true },
                    new AnswerOption { Text = "Inferno", IsCorrect = false },
                    new AnswerOption { Text = "Mirage", IsCorrect = false },
                    new AnswerOption { Text = "Overpass", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "No CS competitivo, quantos rounds são necessários para vencer um mapa no MR15?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "14", IsCorrect = false },
                    new AnswerOption { Text = "15", IsCorrect = false },
                    new AnswerOption { Text = "16", IsCorrect = true },
                    new AnswerOption { Text = "30", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual dessas equipes é da região CIS?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Vitality", IsCorrect = false },
                    new AnswerOption { Text = "G2 Esports", IsCorrect = false },
                    new AnswerOption { Text = "Gambit", IsCorrect = true },
                    new AnswerOption { Text = "FaZe Clan", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Quem foi eleito o melhor jogador do mundo em 2016 pela HLTV?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "s1mple", IsCorrect = false },
                    new AnswerOption { Text = "coldzera", IsCorrect = true },
                    new AnswerOption { Text = "NiKo", IsCorrect = false },
                    new AnswerOption { Text = "device", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual organização ficou conhecida pelo lema 'Fear the North'?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "ENCE", IsCorrect = true },
                    new AnswerOption { Text = "Heroic", IsCorrect = false },
                    new AnswerOption { Text = "North", IsCorrect = false },
                    new AnswerOption { Text = "BIG", IsCorrect = false }
                }
            },

            // =====================
            // CS2
            // =====================

            new Question
            {
                Text = "Qual grande mudança técnica foi introduzida no CS2 em relação aos servidores?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Sub-tick system", IsCorrect = true },
                    new AnswerOption { Text = "128 tick padrão", IsCorrect = false },
                    new AnswerOption { Text = "Rollback de tiros", IsCorrect = false },
                    new AnswerOption { Text = "Matchmaking LAN", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe brasileira foi dominante no cenário de CS 1.6 internacional?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "MIBR", IsCorrect = true },
                    new AnswerOption { Text = "SK Gaming", IsCorrect = false },
                    new AnswerOption { Text = "Luminosity", IsCorrect = false },
                    new AnswerOption { Text = "FURIA", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "No CS 1.6, qual arma era conhecida por matar com um tiro na cabeça sem capacete?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "AK-47", IsCorrect = true },
                    new AnswerOption { Text = "M4A1", IsCorrect = false },
                    new AnswerOption { Text = "FAMAS", IsCorrect = false },
                    new AnswerOption { Text = "Galil", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual organização venceu o primeiro Major oficialmente jogado no CS2?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "FaZe Clan", IsCorrect = false },
                    new AnswerOption { Text = "Natus Vincere", IsCorrect = true },
                    new AnswerOption { Text = "Vitality", IsCorrect = false },
                    new AnswerOption { Text = "G2 Esports", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual mecânica do CS2 mudou significativamente o comportamento das smokes?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Smokes dinâmicas baseadas em física", IsCorrect = true },
                    new AnswerOption { Text = "Smokes fixas por tempo", IsCorrect = false },
                    new AnswerOption { Text = "Smokes atravessáveis", IsCorrect = false },
                    new AnswerOption { Text = "Smokes incendiárias", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe ficou conhecida por dominar o meta do CS2 logo nos primeiros meses?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Team Spirit", IsCorrect = false },
                    new AnswerOption { Text = "Natus Vincere", IsCorrect = true },
                    new AnswerOption { Text = "Vitality", IsCorrect = false },
                    new AnswerOption { Text = "FaZe", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador foi destaque no cenário competitivo do CS2 em 2024?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "donk", IsCorrect = true },
                    new AnswerOption { Text = "monesy", IsCorrect = false },
                    new AnswerOption { Text = "s1mple", IsCorrect = false },
                    new AnswerOption { Text = "fallen", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual mapa retornou ao competitivo com grandes mudanças no CS2?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Inferno", IsCorrect = false },
                    new AnswerOption { Text = "Dust2", IsCorrect = false },
                    new AnswerOption { Text = "Overpass", IsCorrect = true },
                    new AnswerOption { Text = "Cobblestone", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "No CS2 competitivo, quantos rounds são jogados em um half no MR12?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "10", IsCorrect = false },
                    new AnswerOption { Text = "12", IsCorrect = true },
                    new AnswerOption { Text = "15", IsCorrect = false },
                    new AnswerOption { Text = "16", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe venceu vários campeonatos internacionais em 2025?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "G2 Esports", IsCorrect = false },
                    new AnswerOption { Text = "Vitality", IsCorrect = true },
                    new AnswerOption { Text = "ENCE", IsCorrect = false },
                    new AnswerOption { Text = "MOUZ", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual rifle teve mudanças significativas de balanceamento no CS2?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "AK-47", IsCorrect = false },
                    new AnswerOption { Text = "M4A1-S", IsCorrect = true },
                    new AnswerOption { Text = "Galil", IsCorrect = false },
                    new AnswerOption { Text = "FAMAS", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual organização revelou jovens talentos no CS2 competitivo?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Team Spirit", IsCorrect = true },
                    new AnswerOption { Text = "FaZe Clan", IsCorrect = false },
                    new AnswerOption { Text = "Liquid", IsCorrect = false },
                    new AnswerOption { Text = "BIG", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual organização dominou o cenário mundial de CS 1.6 nos anos 2000?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "SK Gaming", IsCorrect = true },
                    new AnswerOption { Text = "Fnatic", IsCorrect = false },
                    new AnswerOption { Text = "Natus Vincere", IsCorrect = false },
                    new AnswerOption { Text = "Astralis", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador brasileiro foi ícone mundial no CS 1.6?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "FalleN", IsCorrect = false },
                    new AnswerOption { Text = "fnx", IsCorrect = false },
                    new AnswerOption { Text = "cogu", IsCorrect = true },
                    new AnswerOption { Text = "fer", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual campeonato era considerado o 'World Cup' do CS 1.6?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "ESL Pro League", IsCorrect = false },
                    new AnswerOption { Text = "IEM", IsCorrect = false },
                    new AnswerOption { Text = "CPL", IsCorrect = true },
                    new AnswerOption { Text = "Blast", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "No CS 1.6 competitivo, qual arma era extremamente dominante pelos CTs?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "FAMAS", IsCorrect = false },
                    new AnswerOption { Text = "AUG", IsCorrect = false },
                    new AnswerOption { Text = "M4A1", IsCorrect = true },
                    new AnswerOption { Text = "MP5", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe europeia rivalizava diretamente com o domínio brasileiro no CS 1.6?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "SK Gaming", IsCorrect = false },
                    new AnswerOption { Text = "Fnatic", IsCorrect = true },
                    new AnswerOption { Text = "NiP", IsCorrect = false },
                    new AnswerOption { Text = "Astralis", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual jogador era conhecido como o melhor AWPer do CS 1.6?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "markeloff", IsCorrect = true },
                    new AnswerOption { Text = "s1mple", IsCorrect = false },
                    new AnswerOption { Text = "device", IsCorrect = false },
                    new AnswerOption { Text = "JW", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "No CS 1.6, qual era o formato clássico de rounds em um mapa?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "MR12", IsCorrect = false },
                    new AnswerOption { Text = "MR15", IsCorrect = true },
                    new AnswerOption { Text = "MR10", IsCorrect = false },
                    new AnswerOption { Text = "MR16", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual desses mapas NÃO fazia parte do competitivo clássico do CS 1.6?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Aztec", IsCorrect = false },
                    new AnswerOption { Text = "Dust2", IsCorrect = false },
                    new AnswerOption { Text = "Cobblestone", IsCorrect = true },
                    new AnswerOption { Text = "Inferno", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual organização brasileira revelou jogadores como yuurih e KSCERATO?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Imperial", IsCorrect = false },
                    new AnswerOption { Text = "MIBR", IsCorrect = false },
                    new AnswerOption { Text = "FURIA", IsCorrect = true },
                    new AnswerOption { Text = "SK Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe brasileira representou o país no PGL Major Stockholm 2021?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Imperial", IsCorrect = false },
                    new AnswerOption { Text = "paiN Gaming", IsCorrect = false },
                    new AnswerOption { Text = "MIBR", IsCorrect = false },
                    new AnswerOption { Text = "FURIA", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual time brasileiro ficou conhecido como 'The Last Dance' em 2022?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "MIBR", IsCorrect = false },
                    new AnswerOption { Text = "FURIA", IsCorrect = false },
                    new AnswerOption { Text = "paiN Gaming", IsCorrect = false },
                    new AnswerOption { Text = "Imperial", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe brasileira teve FalleN como capitão em seu retorno ao cenário internacional?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "paiN Gaming", IsCorrect = false },
                    new AnswerOption { Text = "Imperial", IsCorrect = false },
                    new AnswerOption { Text = "FURIA", IsCorrect = false },
                    new AnswerOption { Text = "MIBR", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe brasileira foi finalista da ESL Pro League Season 3?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "FURIA", IsCorrect = false },
                    new AnswerOption { Text = "SK Gaming", IsCorrect = true },
                    new AnswerOption { Text = "MIBR", IsCorrect = false },
                    new AnswerOption { Text = "Luminosity Gaming", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe brasileira foi semifinalista do IEM Rio Major 2022?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "Imperial", IsCorrect = false },
                    new AnswerOption { Text = "MIBR", IsCorrect = false },
                    new AnswerOption { Text = "paiN Gaming", IsCorrect = false },
                    new AnswerOption { Text = "FURIA", IsCorrect = true }
                }
            },

            new Question
            {
                Text = "Qual equipe brasileira venceu a DreamHack Open Anaheim 2020?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "MIBR", IsCorrect = false },
                    new AnswerOption { Text = "FURIA", IsCorrect = true },
                    new AnswerOption { Text = "SK Gaming", IsCorrect = false },
                    new AnswerOption { Text = "Imperial", IsCorrect = false }
                }
            },

            new Question
            {
                Text = "Qual equipe brasileira ficou famosa pelo bordão 'Aqui é Brasil!' no cenário internacional?",
                ThemeId = cs.Id,
                AnswerOptions = new List<AnswerOption>
                {
                    new AnswerOption { Text = "paiN Gaming", IsCorrect = false },
                    new AnswerOption { Text = "FURIA", IsCorrect = false },
                    new AnswerOption { Text = "MIBR", IsCorrect = false },
                    new AnswerOption { Text = "Luminosity Gaming", IsCorrect = true }
                }
            },

        };

        context.Questions.AddRange(questions);
        context.SaveChanges();
    }
}
