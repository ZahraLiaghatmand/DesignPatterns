using Observer.Observer;
namespace Observer.Observable
{
    public interface IObservable
    {
        public void AttachObserver(IObserver observer);
        public void DetachObserver(IObserver observer);
        public void Notify();
    }
}
