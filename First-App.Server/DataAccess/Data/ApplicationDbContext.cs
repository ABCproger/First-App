using Microsoft.EntityFrameworkCore;

namespace First_App.Server.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
    }
}
