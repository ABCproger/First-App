namespace First_App.Server.Observers.Interfaces
{
    public interface IObserver
    {
        Task UpdateAsync(ICardActivity activity, string action, int cardId);
    }
}
