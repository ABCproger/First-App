using First_App.Server.DataAccess.Interfaces;
using First_App.Server.Entities;
using First_App.Server.Observers.Interfaces;

namespace First_App.Server.Observers
{
    public class CreateCardObserver : ICreateCardObserver
    {
        private readonly ICardActivityLogsRepository _cardActivityLogsRepository;
        public CreateCardObserver(ICardActivityLogsRepository cardActivityLogsRepository)
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
