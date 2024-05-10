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

        public async Task AddAsync(Board entity)
        {
            await dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Board>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<Board> GetByIdAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            return entity;
        }

        public async Task<bool> UpdateAsync(Board entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            var result = await dbSet.FindAsync(entity.Id);
            if(result != null)
            {
                result.Name = entity.Name;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
