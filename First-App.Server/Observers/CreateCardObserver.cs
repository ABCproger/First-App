using First_App.Server.DataAccess.Interfaces;
using First_App.Server.Entities;
using First_App.Server.Observers.Interfaces;

namespace First_App.Server.Observers
{
    //public class CreateCardObserver : IObserver
    //{
    //    private readonly ICardActivityLogsRepository _cardActivityLogsRepository;
    //    public CreateCardObserver(ICardActivityLogsRepository cardActivityLogsRepository)
    //    {
    //        _cardActivityLogsRepository = cardActivityLogsRepository;
    //    }
    //    public async Task UpdateAsync(ICardActivity activity)
    //    {
    //        await _cardActivityLogsRepository.AddAsync(new CardActivityLog()
    //              {
    //                  Action = $"You added {(activity as CardActivity).NewCardName}",
    //                  ActivityTime = DateTime.Now,
    //                  CardId = (activity as CardActivity).CardId ,
    //              });
    //    }
    //}
}
