namespace First_App.Server.Observers.Interfaces
{
    public interface IObserver
    {
        Task Update(ICardActivity activity);
    }
}
