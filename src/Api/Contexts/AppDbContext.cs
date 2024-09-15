using Microsoft.EntityFrameworkCore;
using MiniHackaton.Domain.Entities;

namespace MiniHackaton.Api.Contexts
{
    public class AppDbContext : DbContext
    {
        #region Tables
        public DbSet<LearningPath> LearningPaths { get; set; }
        public DbSet<Learningpathlink> Learningpathlinks { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Mentorspecialization> Mentorspecializations { get; set; }
        public DbSet<Platform> Platform { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
         public DbSet<StudenLearningPath> StudenLearningPaths { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
    }
}
