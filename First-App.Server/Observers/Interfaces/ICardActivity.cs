namespace First_App.Server.Observers.Interfaces
{
    public interface ICardActivity
    {
        Task AttachAsync(IObserver observer);
        Task DetachAsync(IObserver observer);
        Task NotifyAsync(string action, string cardName);
    }
}
