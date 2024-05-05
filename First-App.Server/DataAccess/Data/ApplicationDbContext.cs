using First_App.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_App.Server.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Board> Boards { get; set; }
        public DbSet<CardColumn> CardColumns { get; set; }
        public DbSet<Card> cards { get; set; }
    }
}
