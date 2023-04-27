using Microsoft.EntityFrameworkCore;
using QuizAPI.Models;
using System.Security.Principal;

namespace QuizAPi.Models
{
    public class QuizDbContext:DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options):base(options)// (ctor) parameters of the type DbContextOptions
        { }

        public DbSet <Question> Questions{ get; set; }
        public DbSet<Participant>Participants  { get; set; }
    }
}
 