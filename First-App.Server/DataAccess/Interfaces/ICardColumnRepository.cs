using First_App.Server.Entities;

namespace First_App.Server.DataAccess.Interfaces
{
    public interface ICardColumnRepository : IRepository<CardColumn>
    {
        Task<IEnumerable<CardColumn>> GetColumnsByBoardIdAsync(int boardId);
    }
}
