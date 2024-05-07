using First_App.Server.DataAccess.Helpers;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.DataTransferObjects.Responces;
using First_App.Server.Entities;

namespace First_App.Server.DataAccess.Interfaces
{
    public interface ICardActivityLogsRepository
    {
        Task AddAsync(CardActivityLog entity);
        Task<PagedList<GetCardActivityResponse>> GetCardActivitiesAsync(int cardId, int page, int pageSize);
    }
}
