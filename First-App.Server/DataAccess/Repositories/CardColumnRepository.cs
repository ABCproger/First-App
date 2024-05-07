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

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CardColumn>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<CardColumn> GetByIdAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity == null)
            {
                throw new ArgumentNullException($"CardColumn with ID {entity.Id} not found");
            }
            return entity;
        }

        public async Task UpdateAsync(CardColumn entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            var result = await dbSet.FindAsync(entity.Id);
            if (result == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            result.BoardId = entity.BoardId;
            result.Name = entity.Name;
            await _context.SaveChangesAsync();
        }
    }
}

