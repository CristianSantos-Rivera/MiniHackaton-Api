using Microsoft.EntityFrameworkCore;

namespace MiniHackaton.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        #region Tables

        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        
    }
}
