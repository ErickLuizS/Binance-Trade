namespace Binance.Spot.Tests
{
    using System.Net;
    using System.Net.Http;
    using Binance.Spot.Models;
    using Moq;
    using Moq.Protected;
    using Xunit;

    public class PortfolioMargin_Tests
    {
        private string apiKey = "api-key";
        private string apiSecret = "api-secret";

        #region GetPortfolioMarginAccountInfo
        [Fact]
        public async void GetPortfolioMarginAccountInfo_Response()
        {
            var responseContent = "{\"uniMMR\":\"1.87987800\",\"accountEquity\":\"122607.35137903\",\"accountMaintMargin\":\"23.72469206\",\"accountStatus\":\"NORMAL\"}";
            var mockMessageHandler = new Mock<HttpMessageHandler>();
            mockMessageHandler.Protected()
                .SetupSendAsync("/sapi/v1/portfolio/account", HttpMethod.Get)
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent(responseContent),
                });
            PortfolioMargin portfolioMargin = new PortfolioMargin(
                new HttpClient(mockMessageHandler.Object),
                apiKey: this.apiKey,
                apiSecret: this.apiSecret);

            var result = await portfolioMargin.GetPortfolioMarginAccountInfo();

            Assert.Equal(responseContent, result);
        }
        #endregion

        #region PortfolioMarginCollateralRate
        [Fact]
        public async void PortfolioMarginCollateralRate_Response()
        {
            var responseContent = "[{\"asset\":\"USDC\",\"collateralRate\":\"1.0000\"},{\"asset\":\"BUSD\",\"collateralRate\":\"1.0000\"}]";
            var mockMessageHandler = new Mock<HttpMessageHandler>();
            mockMessageHandler.Protected()
                .SetupSendAsync("/sapi/v1/portfolio/collateralRate", HttpMethod.Get)
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent(responseContent),
                });
            PortfolioMargin portfolioMargin = new PortfolioMargin(
                new HttpClient(mockMessageHandler.Object),
                apiKey: this.apiKey,
                apiSecret: this.apiSecret);

            var result = await portfolioMargin.PortfolioMarginCollateralRate();

            Assert.Equal(responseContent, result);
        }
        #endregion

        #region QueryPortfolioMarginBankruptcyLoanAmount
        [Fact]
        public async void QueryPortfolioMarginBankruptcyLoanAmount_Response()
        {
            var responseContent = "{\"asset\":\"BUSD\",\"amount\":\"579.45\"}";
            var mockMessageHandler = new Mock<HttpMessageHandler>();
            mockMessageHandler.Protected()
                .SetupSendAsync("/sapi/v1/portfolio/pmLoan", HttpMethod.Get)
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent(responseContent),
                });
            PortfolioMargin portfolioMargin = new PortfolioMargin(
                new HttpClient(mockMessageHandler.Object),
                apiKey: this.apiKey,
                apiSecret: this.apiSecret);

            var result = await portfolioMargin.QueryPortfolioMarginBankruptcyLoanAmount();

            Assert.Equal(responseContent, result);
        }
        #endregion

        #region PortfolioMarginBankruptcyLoanRepay
        [Fact]
        public async void PortfolioMarginBankruptcyLoanRepay_Response()
        {
            var responseContent = "{\"tranId\":58203331886213504}";
            var mockMessageHandler = new Mock<HttpMessageHandler>();
            mockMessageHandler.Protected()
                .SetupSendAsync("/sapi/v1/portfolio/repay", HttpMethod.Post)
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent(responseContent),
                });
            PortfolioMargin portfolioMargin = new PortfolioMargin(
                new HttpClient(mockMessageHandler.Object),
                apiKey: this.apiKey,
                apiSecret: this.apiSecret);

            var result = await portfolioMargin.PortfolioMarginBankruptcyLoanRepay();

            Assert.Equal(responseContent, result);
        }
        #endregion
    }
}