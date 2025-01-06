using Observer.ConcreteObservable;
using Observer.Observer;

namespace Observer.ConcreteObserver
{
    public class StockListView : IObserver
    {
        private readonly Stock _stock;
        public StockListView(Stock stockData)
        {
            _stock = stockData;
            stockData.AttachObserver(this);
        }
        public void Update()
        {
            Console.WriteLine("stockListView was notified");
        } 
    }
}
