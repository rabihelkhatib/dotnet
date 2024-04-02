namespace StockMarket.ServicesContracts
{
    public interface IFinnhubService
    {
        Task<Dictionary<string, object>?> GetStockPriceQuote(string stockSymbol);
    }
}
