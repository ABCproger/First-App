using First_App.Server.DataAccess.Data;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_App.Server.DataAccess.Repositories
{
    public class PriorityRepository :AbstractRepository, IPriorityRepository
    {
        private readonly DbSet<Priority> dbSet;
        public PriorityRepository(ApplicationDbContext context) : base(context)
        {
            dbSet = context.Set<Priority>();
        }
        public Task AddAsync(Priority entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Priority>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Priority> GetByIdAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            return entity;
        }

        public Task<bool> UpdateAsync(Priority entity)
        {
            throw new NotImplementedException();
        }
    }
}
