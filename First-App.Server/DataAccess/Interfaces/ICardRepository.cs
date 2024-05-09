using First_App.Server.Entities;

namespace First_App.Server.DataAccess.Interfaces
{
    public interface ICardRepository : IRepository<Card>
    {
        Task<IEnumerable<Card>> GetCardColumnCardsAsync(int cardColumnId);
    }
}
