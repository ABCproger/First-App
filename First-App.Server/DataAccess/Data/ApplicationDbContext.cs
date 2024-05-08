using First_App.Server.DataAccess.Data.InitDataFactory;
using First_App.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_App.Server.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<CardColumn> CardColumns { get; set; }
        public DbSet<Card> cards { get; set; }
        public DbSet<CardActivityLog> CardActivityLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            TestDataFactory factory = new TestDataFactory();
            modelBuilder.Entity<Board>().HasData(factory.GetBoardData());
            modelBuilder.Entity<CardColumn>().HasData(factory.GetCardColumnData());
            modelBuilder.Entity<Card>().HasData(factory.GetCardData());
            modelBuilder.Entity<Priority>().HasData(factory.GetPriorityData());
            modelBuilder.Entity<CardActivityLog>().HasData(factory.GetActivityLogData());
        }
    }
}
