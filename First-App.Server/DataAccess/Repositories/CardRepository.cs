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

        public async Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Card>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<Card> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Card entity)
        {
            throw new NotImplementedException();
        }
    }
}
