using Microsoft.EntityFrameworkCore;
using MiniHackaton.Domain.Entities;

namespace MiniHackaton.Api.Contexts
{
    public class AppDbContext : DbContext
    {
        #region Tables
        public DbSet<LearningPath> LearningPaths { get; set; }
        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
    }
}
