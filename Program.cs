using System;
using Alpaca.Markets;
using System.Threading.Tasks;

namespace AlpacaExample
{
    internal static class Program
    {
        private const String KEY_ID = "";
        private const String SECRET_KEY = "";
        private const String SYMBOL = "AAPL";
        private const Decimal FractionalQuantity = 0.555M;

        public static async Task Main()
        {
            var client = Environments.Paper
                .GetAlpacaTradingClient(new SecretKey(KEY_ID, SECRET_KEY));

            var clock = await client.GetClockAsync();

            if (clock != null)
            {
                Console.WriteLine(
                    "Timestamp: {0}, NextOpen: {1}, NextClose: {2}",
                    clock.TimestampUtc, clock.NextOpenUtc, clock.NextCloseUtc);

                var order = await client.PostOrderAsync(
                    MarketOrder.Buy(SYMBOL, OrderQuantity.Fractional(FractionalQuantity)));

                Console.WriteLine("Buy: " + SYMBOL + " OrderQuantity: " + FractionalQuantity);
            }
        }
    }
}