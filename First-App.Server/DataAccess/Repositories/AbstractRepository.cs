using First_App.Server.DataAccess.Data;

namespace First_App.Server.DataAccess.Repositories
{
    public class AbstractRepository
    {
        protected readonly ApplicationDbContext _context;

        protected AbstractRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
