using First_App.Server.DataAccess.Data;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_App.Server.DataAccess.Repositories
{
    public class CardColumnRepository : AbstractRepository, ICardColumnRepository
    {
        private readonly DbSet<CardColumn> dbSet;
        public CardColumnRepository(ApplicationDbContext context) : base(context)
        {
            dbSet = context.Set<CardColumn>();
        }

        public async Task AddAsync(CardColumn entity)
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

        public async Task<IEnumerable<CardColumn>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<CardColumn> GetByIdAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            return entity;
        }

        public async Task<IEnumerable<CardColumn>> GetColumnsByBoardIdAsync(int boardId)
        {
            var columns = await dbSet.Where(c => c.BoardId == boardId).ToListAsync();
            return columns;
        }

        public async Task<bool> UpdateAsync(CardColumn entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            var result = await dbSet.FindAsync(entity.Id);
            if (result == null)
            {
                return false;
            }
            result.BoardId = entity.BoardId;
            result.Name = entity.Name;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

