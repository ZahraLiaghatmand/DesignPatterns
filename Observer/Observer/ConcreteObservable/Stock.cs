using Observer.Observable;
using Observer.Observer;

namespace Observer.ConcreteObservable
{
    public class Stock : IObservable
    {
        private readonly List<IObserver> _observers;
        public Dictionary<string, decimal> StockPrices;

        public Stock()
        {
            _observers = new List<IObserver>();
            StockPrices = new Dictionary<string, decimal>();
        }
        public void AttachObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers) { observer.Update(); }
        }

        // Method to set the stock price
        public void SetStockPrice(string stockName, decimal price)
        {
            StockPrices[stockName] = price;
            Notify();
        }

        // Method to get the current stock price
        public decimal GetStockPrice(string stockName)
        {
            return StockPrices.ContainsKey(stockName) ? StockPrices[stockName] : 0;
        }
    }
}