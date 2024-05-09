using First_App.Server.DataAccess.Interfaces;
using First_App.Server.Entities;
using First_App.Server.Observers.Interfaces;

namespace First_App.Server.Observers
{
    public class EditCardObserver : IEditCardObserver
    {
        private readonly ICardActivityLogsRepository _cardActivityLogsRepository;
        public EditCardObserver(ICardActivityLogsRepository cardActivityLogsRepository)
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
