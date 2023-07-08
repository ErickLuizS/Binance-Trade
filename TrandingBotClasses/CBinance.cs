using Binance.Common;
using Binance.Spot;
using Binance.Spot.Models;
using L2.Services;
using Newtonsoft.Json;

namespace TrandingBotClasses
{
    public class CBinance
    {


        public Guid CBinanceId { get; set; }
        public string apiKey { get; set; }
        public string apiSecret { get; set; }
        public enum TipoOrdem { Market, StopLossOrder, StopLossLimitOrder, OcoOrder }
        public enum TiposLado { venda, compra }
        private SpotAccountTrade SpotAccountTrade;
        private Wallet Wallet;
        Cryptography Ccryptography = new Cryptography(Cryptography.Key);

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<Trade> Trades { get; set; }

        public CBinance() { }


        /// <summary>
        ///Cria um SpotAccountTrade para o objeto.<para />
        /// </summary>   
        public async Task CreateSpot()
        {
             string ApiKey = Ccryptography.Decrypt(this.apiKey);
             string ApiSecret = Ccryptography.Decrypt(this.apiSecret);

            SpotAccountTrade = new SpotAccountTrade(new HttpClient(), baseUrl: "https://testnet.binance.vision", apiKey: ApiKey, apiSecret: ApiSecret);

        }


        /// <summary>
        ///Realiz qualquer tipo de operação de trade.<para />
        /// </summary>       
        /// <param name="tipo">Tipo da ordem.</param>
        /// <param name="lado">Lado da ordem.</param>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <param name="qtd">Quantidade da ordem.</param>
        /// <param name="price">Preço da ordem.</param>
        /// <param name="stop">Usado com ordens como STOP_LOSS, STOP_LOSS_LIMIT.</param>
        public async Task RealizarOrdens(TipoOrdem tipo, TiposLado lado, string par, decimal qtd, decimal? price, decimal? stop)
        {
            switch (tipo)
            {


                case TipoOrdem.Market:

                    if (lado == TiposLado.compra)
                    {
                        await this.MarketBuy(par, qtd);

                    }
                    if (lado == TiposLado.venda)
                    {
                        await this.MarketSell(par, qtd);
                    }
                    break;

                case TipoOrdem.StopLossOrder:
                    if (lado == TiposLado.compra)
                    {
                        await this.BStopLossOrder(par, qtd, (decimal)stop);

                    }
                    if (lado == TiposLado.venda)
                    {
                        await this.SStopLossOrder(par, qtd, (decimal)stop);

                    }
                    break;

                case TipoOrdem.StopLossLimitOrder:

                    if (lado == TiposLado.compra)
                    {
                        await this.BStopLossLimitOrder(par, qtd, (decimal)price, (decimal)stop);

                    }
                    if (lado == TiposLado.venda)
                    {
                        await this.SStopLossLimitOrder(par, qtd, (decimal)price, (decimal)stop);

                    }
                    break;

                case TipoOrdem.OcoOrder:

                    if (lado == TiposLado.compra)
                    {
                        await this.BOcoOrder(par, qtd, (decimal)price, (decimal)stop);

                    }
                    if (lado == TiposLado.venda)
                    {
                        await this.SOcoOrder(par, qtd, (decimal)price, (decimal)stop);

                    }
                    break;











            }

        }


        /// <summary>
        /// Retorna a quantidade de moeda disponivel para operação na conta.<para />
        /// </summary>
        /// <returns>quantidade de moeda disponivel para operação</returns>
        public async Task<double> Moeda(string Moeda)
        {
            double result = 0;

            string Balanço = await InfoConta();
            object? v = JsonConvert.DeserializeObject(Balanço);
            dynamic Conta = v;
            foreach (var moeda in Conta.balances)
            {
                if (moeda.asset == Moeda)
                {
                    result = moeda.free;

                }

            }


            return result;


        }


        /// <summary>
        /// Retorna informações sobre a conta.<para />
        /// </summary>
        /// <returns>string com informações da conta</returns>
        public async Task<string> InfoConta()
        {

            try
            {

                var result = await SpotAccountTrade.AccountInformation(recvWindow: 40000);

                return result;

            }
            catch (BinanceClientException e)
            {
                return e.Message;
            }
        }


        /// <summary>
        ///Retorna a lista de trades realizados de um par<para />
        /// </summary>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <returns> lista de trades </returns>
        public async Task<string> TradeList(string par)
        {



            var result = await SpotAccountTrade.AccountTradeList(par, recvWindow: 40000);



            return result;

        }


        /// <summary>
        ///Retorna todas as ordens; ativas, canceladas, ou finalizadas<para />
        /// </summary>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <returns> lista de Ordens </returns>
        public async Task<string> Ordens(string par)
        {

            var result = await SpotAccountTrade.AllOrders(par, recvWindow: 40000);



            return result;

        }


        /// <summary>
        ///Realiza uma nova ordem de venda<para />
        /// </summary>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <param name="qtd">Quantidade da ordem.</param>
        /// <returns>Resultado da Ordem.</returns>
        public async Task<string> MarketSell(string par, decimal qtd)
        {

            var result = await SpotAccountTrade.NewOrder(par, Side.SELL, OrderType.MARKET, quantity: qtd, recvWindow: 40000);

            return result;



        }


        /// <summary>
        ///Realiza uma nova ordem de compra<para />
        /// </summary>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <param name="qtd">Quantidade da ordem.</param>
        /// <returns>Resultado da Ordem.</returns>
        public async Task<string> MarketBuy(string par, decimal qtd)
        {
            try
            {
                var result = await SpotAccountTrade.NewOrder(par, Side.BUY, OrderType.MARKET, quantity: qtd, recvWindow: 40000);

                return result;

            }
            catch (BinanceClientException e)
            {
                return e.Message;
            }



        }


        /// <summary>
        ///Realiza uma nova ordem de Stop Loss do lado da venda<para />
        /// </summary>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <param name="qtd">Quantidade da ordem.</param>
        /// <param name="stop">Usado com ordens como STOP_LOSS, STOP_LOSS_LIMIT.</param>
        /// <returns>Resultado da Ordem.</returns>
        public async Task<string> SStopLossOrder(string par, decimal qtd, decimal stop)
        {


            var result = await SpotAccountTrade.NewOrder(par, Side.SELL, OrderType.STOP_LOSS, quantity: qtd, stopPrice: stop, recvWindow: 40000);
            return result;

        }


        /// <summary>
        ///Realiza uma nova ordem de Stop Loss do lado da compra<para />
        /// </summary>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <param name="qtd">Quantidade da ordem.</param>
        /// <param name="stop">Usado com ordens como STOP_LOSS, STOP_LOSS_LIMIT.</param>
        /// <returns>Resultado da Ordem.</returns>
        public async Task<string> BStopLossOrder(string par, decimal qtd, decimal stop)
        {


            var result = await SpotAccountTrade.NewOrder(par, Side.BUY, OrderType.STOP_LOSS, quantity: qtd, stopPrice: stop, recvWindow: 40000);
            return result;

        }


        /// <summary>
        ///Realiza uma nova ordem de Stop Loss Limit do lado da venda<para />
        /// </summary>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <param name="qtd">Quantidade da ordem.</param>
        /// <param name="stop">Usado com ordens como STOP_LOSS, STOP_LOSS_LIMIT.</param>
        /// <param name="price">Preço da ordem.</param>
        /// <returns>Resultado da Ordem.</returns>
        public async Task<string> SStopLossLimitOrder(string par, decimal qtd, decimal price, decimal stop)
        {


            var result = await SpotAccountTrade.NewOrder(par, Side.SELL, OrderType.STOP_LOSS_LIMIT, TimeInForce.GTC, quantity: qtd, price: price, stopPrice: stop, recvWindow: 40000);

            return result;


        }


        /// <summary>
        ///Realiza uma nova ordem de Stop Loss Limit do lado da compra<para />
        /// </summary>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <param name="qtd">Quantidade da ordem.</param>
        /// <param name="stop">Usado com ordens como STOP_LOSS, STOP_LOSS_LIMIT.</param>
        /// <param name="price">Preço da ordem.</param>        
        /// <returns>Resultado da Ordem.</returns>
        public async Task<string> BStopLossLimitOrder(string par, decimal qtd, decimal price, decimal stop)
        {


            var result = await SpotAccountTrade.NewOrder(par, Side.BUY, OrderType.STOP_LOSS_LIMIT, TimeInForce.GTC, quantity: qtd, price: price, stopPrice: stop, recvWindow: 40000);

            return result;


        }


        /// <summary>
        ///Realiza uma noca Oco Order do lado da compra<para />
        /// </summary>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <param name="qtd">Quantidade da ordem.</param>
        /// <param name="stop">Usado com ordens como STOP_LOSS, STOP_LOSS_LIMIT.</param>
        /// <param name="price">Preço da ordem.</param>
        /// <returns>Resultado da Ordem.</returns>
        public async Task<string> BOcoOrder(string par, decimal qtd, decimal price, decimal stop)
        {

            var result = await SpotAccountTrade.NewOco(par, Side.BUY, qtd, price, stop, TimeInForce.GTC, recvWindow: 40000);

            return result;




        }


        /// <summary>
        ///Realiza uma noca Oco Order do lado da venda<para />
        /// </summary>
        /// <param name="par">Símbolo de negociação, por exemplo, BNBUSDT.</param>
        /// <param name="qtd">Quantidade da ordem.</param>
        /// <param name="stop">Usado com ordens como STOP_LOSS, STOP_LOSS_LIMIT.</param>
        /// <param name="price">Preço da ordem.</param>
        /// <returns>Resultado da Ordem.</returns>
        public async Task<string> SOcoOrder(string par, decimal qtd, decimal price, decimal stop)
        {

            var result = await SpotAccountTrade.NewOco(par, Side.SELL, qtd, price, stop, TimeInForce.GTC, recvWindow: 40000);

            return result;




        }


    }



}

























