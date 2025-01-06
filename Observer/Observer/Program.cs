using Observer.ConcreteObservable;
using Observer.ConcreteObserver;

var stock = new Stock();
var stockListView = new StockListView(stock);

stock.SetStockPrice("AAPL", 150.25m);
stock.SetStockPrice("GOOGL", 2750.60m);
stock.SetStockPrice("MSFT", 299.99m);
stock.SetStockPrice("AMZN", 3500.45m);