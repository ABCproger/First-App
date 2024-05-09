using First_App.Server.DataAccess.Data;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_App.Server.DataAccess.Repositories
{
    public class CardRepository : AbstractRepository, ICardRepository
    {
        private readonly DbSet<Card> dbSet;
        public CardRepository(ApplicationDbContext context) : base(context)
        {
            dbSet = context.Set<Card>();
        }
        public async Task AddAsync(Card entity)
        {
            await dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            if(entity != null)
            {
                dbSet.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Card>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<Card> GetByIdAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            return entity;
        }

        public async Task<IEnumerable<Card>> GetCardColumnCardsAsync(int cardColumnId)
        {
            var cards = await dbSet.Where(x => x.CardColumnId == cardColumnId).ToListAsync();
            return cards;
        }

        public async Task<bool> UpdateAsync(Card entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            var result = await dbSet.FindAsync(entity.Id);
            if(result != null)
            {
                result.Name = entity.Name;
                result.Description = entity.Description;
                result.DueDate = entity.DueDate;
                result.CardColumnId = entity.CardColumnId;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
            
        }
    }
}
