using First_App.Server.Observers.Interfaces;

namespace First_App.Server.Observers
{
    public class CardActivity : ICardActivity
    {
        private List<IObserver> _observers = new List<IObserver>();
        public Task AttachAsync(IObserver observer)
        {
            _observers.Add(observer);
            return Task.CompletedTask;
        }

        public Task DetachAsync(IObserver observer)
        {
            _observers.Remove(observer);
            return Task.CompletedTask;
        }

        public async Task NotifyAsync(string action, string cardName)
        {
            foreach(var observer in _observers)
            {
                await observer.UpdateAsync(this, action, cardName);
            }
        }
    }
}
