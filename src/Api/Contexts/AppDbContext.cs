using Microsoft.EntityFrameworkCore;

namespace MiniHackaton.Api.Contexts
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
