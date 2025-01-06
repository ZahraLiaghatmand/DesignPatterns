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
            DisplayAllStocks();
        }
        private void DisplayAllStocks()
        {
            foreach (var stock in _stock.GetAllStockPrices())
            {
                Console.WriteLine($"{stock.Key}: {stock.Value:C}");
            }
        }
    }
    public static class StockDataExtensions
    {
        public static Dictionary<string, decimal> GetAllStockPrices(this Stock stock)
        {
            return new Dictionary<string, decimal>(stock.StockPrices);
        }
    }
}