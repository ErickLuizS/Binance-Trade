namespace Binance.Spot.PortfolioMarginExamples
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Binance.Common;
    using Binance.Spot;
    using Binance.Spot.Models;
    using Microsoft.Extensions.Logging;

    public class QueryPortfolioMarginBankruptcyLoanAmount_Example
    {
        public static async Task Main(string[] args)
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
            });
            ILogger logger = loggerFactory.CreateLogger<QueryPortfolioMarginBankruptcyLoanAmount_Example>();

            HttpMessageHandler loggingHandler = new BinanceLoggingHandler(logger: logger);
            HttpClient httpClient = new HttpClient(handler: loggingHandler);

            string apiKey = "api-key";
            string apiSecret = "api-secret";

            var portfolioMargin = new PortfolioMargin(httpClient, apiKey: apiKey, apiSecret: apiSecret);

            var result = await portfolioMargin.QueryPortfolioMarginBankruptcyLoanAmount();
        }
    }
}