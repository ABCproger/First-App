using First_App.Server.DataAccess.Data;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_App.Server.DataAccess.Repositories
{
    public class BoardRepository : AbstractRepository, IBoardRepository
    {
        private readonly DbSet<Board> dbSet;
        public BoardRepository(ApplicationDbContext context) : base(context)
        {
            dbSet = context.Set<Board>();
        }

        public Task AddAsync(Board entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Board>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Board> GetByIdAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            return entity;
        }

        public Task<bool> UpdateAsync(Board entity)
        {
            throw new NotImplementedException();
        }
    }
}
