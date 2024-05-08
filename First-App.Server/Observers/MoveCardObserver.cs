using First_App.Server.DataAccess.Interfaces;
using First_App.Server.Entities;
using First_App.Server.Observers.Interfaces;

namespace First_App.Server.Observers
{
    public class MoveCardObserver : IMoveCardObserver
    {
        private readonly ICardActivityLogsRepository _cardActivityLogsRepository;
        public MoveCardObserver(ICardActivityLogsRepository cardActivityLogsRepository)
        {
            _cardActivityLogsRepository = cardActivityLogsRepository;
        }

        public async Task UpdateAsync(ICardActivity activity, string action, int cardId)
        {
            var activityLog = new CardActivityLog()
            {
                Action = $"{action}",
                ActivityTime = DateTime.Now,
                CardId = cardId,
            };
            await _cardActivityLogsRepository.AddAsync(activityLog);
        }
    }
}
