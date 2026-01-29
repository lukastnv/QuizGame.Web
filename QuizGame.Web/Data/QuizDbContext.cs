using Microsoft.EntityFrameworkCore;
using QuizGame.Web.Models;
using System.Collections.Generic;
using System.Numerics;

namespace QuizGame.Web.Data
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options)
            : base(options)
        {
        }

        public DbSet<Theme> Themes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerOption> AnswerOptions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<GameSession> GameSessions { get; set; }
        public DbSet<GameSessionQuestion> GameSessionQuestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameSessionQuestion>()
                .HasOne(gsq => gsq.GameSession)
                .WithMany(gs => gs.Questions)
                .HasForeignKey(gsq => gsq.GameSessionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GameSessionQuestion>()
                .HasOne(gsq => gsq.Question)
                .WithMany()
                .HasForeignKey(gsq => gsq.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GameSessionQuestion>()
                .HasOne(gsq => gsq.SelectedAnswer)
                .WithMany()
                .HasForeignKey(gsq => gsq.SelectedAnswerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }



}
