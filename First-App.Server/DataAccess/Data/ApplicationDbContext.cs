using First_App.Server.DataAccess.Data.InitDataFactory;
using First_App.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
            base.OnModelCreating(modelBuilder);
            TestDataFactory factory = new TestDataFactory();
            modelBuilder.Entity<Board>().HasData(factory.GetBoardData());
            modelBuilder.Entity<CardColumn>().HasData(factory.GetCardColumnData());
            modelBuilder.Entity<Card>().HasData(factory.GetCardData());
            modelBuilder.Entity<Priority>().HasData(factory.GetPriorityData());
            modelBuilder.Entity<CardActivityLog>().HasData(factory.GetActivityLogData());

            modelBuilder.Entity<Board>(ConfigureBoard);
            modelBuilder.Entity<Card>(ConfigureCard);
            modelBuilder.Entity<CardActivityLog>(ConfigureCardActivityLog);
            modelBuilder.Entity<CardColumn>(ConfigureCardColumn);
            modelBuilder.Entity<Priority>(ConfigurePriority);
        }
        private void ConfigureBoard(EntityTypeBuilder<Board> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired();

            builder.HasMany(b => b.Columns)
                   .WithOne(c => c.Board)
                   .HasForeignKey(c => c.BoardId)
                   .OnDelete(DeleteBehavior.Restrict);
        }

        private void ConfigureCard(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Description).IsRequired(false);
            builder.Property(c => c.DueDate).IsRequired(false);

            builder.HasOne(c => c.CardColumn)
                   .WithMany(cc => cc.Cards)
                   .HasForeignKey(c => c.CardColumnId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Priority)
                   .WithMany(p => p.Cards)
                   .HasForeignKey(c => c.PriorityId)
                   .OnDelete(DeleteBehavior.Restrict);
        }

        private void ConfigureCardActivityLog(EntityTypeBuilder<CardActivityLog> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Action).IsRequired();
            builder.Property(c => c.ActivityTime).IsRequired();

            builder.HasOne(c => c.Card)
                   .WithMany(ca => ca.CardActivityLogs)
                   .HasForeignKey(c => c.CardId)
                   .OnDelete(DeleteBehavior.Restrict);
        }

        private void ConfigureCardColumn(EntityTypeBuilder<CardColumn> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired();

            builder.HasMany(c => c.Cards)
                   .WithOne(card => card.CardColumn)
                   .HasForeignKey(card => card.CardColumnId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Board)
                   .WithMany(b => b.Columns)
                   .HasForeignKey(c => c.BoardId)
                   .OnDelete(DeleteBehavior.Restrict);
        }

        private void ConfigurePriority(EntityTypeBuilder<Priority> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
        }
    }
}

