using AutoMapper;
using First_App.Server.DataAccess.Data;
using First_App.Server.DataAccess.Helpers;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.DataTransferObjects.Responces;
using First_App.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_App.Server.DataAccess.Repositories
{
    public class CardActivityLogsRepository : AbstractRepository, ICardActivityLogsRepository
    {
        private readonly DbSet<CardActivityLog> dbSet;
        private readonly IMapper _mapper;
        public CardActivityLogsRepository(ApplicationDbContext context,IMapper mapper) : base(context)
        {
            dbSet = context.Set<CardActivityLog>();
            _mapper = mapper;
        }

        public async Task AddAsync(CardActivityLog entity)
        {
            await dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<PagedList<GetCardActivityResponse>> GetCardActivitiesAsync(int cardId, int page, int pageSize)
        {
            var query = dbSet.Where(x => x.CardId == cardId);
            var mappedQuery = _mapper.ProjectTo<GetCardActivityResponse>(query);
            var response = await PagedList<GetCardActivityResponse>.CreateAsync(mappedQuery, page, pageSize);
            return response;
        }
    }
}
